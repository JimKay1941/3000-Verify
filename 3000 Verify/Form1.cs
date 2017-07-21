using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using _3000_Verify.Properties;

namespace _3000_Verify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = _myLanguages[Properties.Settings.Default.Know];

            gridOneMain.Rows.Clear();

            using (var d3K = new Dictionary3000DataContext(Properties.Settings.Default.ChineseStudyConnection))
            {
                IOrderedQueryable<_3000_Character> trads;
                if (!chkByPass.Checked)
                {
                    trads = from q in d3K._3000_Characters
                                where (q.Traditional.Contains(txtMainCharacter.Text) /* && q.FEseq == "0" */)
                                orderby q.FEseq
                                select q;
                }
                else
                {
                    trads = from q in d3K._3000_Characters
                                where q.Traditional.Contains(txtMainCharacter.Text)
                                orderby q.FEseq
                                select q;
                }
                gridOneMain.SelectAll();

                var fePrefix = txtFEsequence.Text;
                var fePrefixLength = fePrefix.Length;
                foreach (var trad in trads)
                {
                    var feFull = trad.FEseq.ToString(CultureInfo.InvariantCulture);
                    if (!chkByPass.Checked && trad.FEseq != "0" &&
                        (((feFull.Length != fePrefixLength + 2)) || (feFull.Substring(0, fePrefixLength) != fePrefix)) &&
                        (((feFull.Length != fePrefixLength)) || (feFull != fePrefix))) continue;
                    object[] row = {trad.ID.ToString(CultureInfo.InvariantCulture), trad.FEseq, trad.Zhuyin, trad.Traditional, trad.English, trad.NumPinyin, trad.CritPinyin, trad.Simplified, trad.Cji};
                    gridOneMain.Rows.Add(row);
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chineseStudyDataSet._3000_Characters' table. You can move, or remove it, as needed.
            //_3000_CharactersTableAdapter.Fill(chineseStudyDataSet._3000_Characters);

            var index = 0;
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                _myLanguages[index] = lang;
                index++;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = _myLanguages[Properties.Settings.Default.Know];

            gridOneMain.Rows.Clear();

            using (var d3K = new Dictionary3000DataContext(Properties.Settings.Default.ChineseStudyConnection))
            {
                IOrderedQueryable<_3000_Character> trads;
                if (!chkByPass.Checked)
                {
                    trads = from q in d3K._3000_Characters
                                where (q.Traditional == txtMainCharacter.Text && q.FEseq == "0")
                                orderby q.English
                                select q;
                }
                else
                {
                    trads = from q in d3K._3000_Characters
                                where q.Traditional == txtMainCharacter.Text
                                orderby q.English
                                select q;
                }

                foreach (var trad in trads)
                {
                    object[] row = { trad.ID.ToString(CultureInfo.InvariantCulture), trad.FEseq, trad.Zhuyin, trad.Traditional, trad.English, trad.NumPinyin, trad.CritPinyin, trad.Simplified, trad.Cji };
                    gridOneMain.Rows.Add(row);
                }

            }
        }

        private void gridOneMain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateRow();
        }

        private void UpdateRow()
        {
            InputLanguage.CurrentInputLanguage = _myLanguages[Properties.Settings.Default.Know];

            if (gridOneMain.CurrentRow == null) return;
            var idstring = gridOneMain.CurrentRow.Cells[0].EditedFormattedValue.ToString();
            var feseq = gridOneMain.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            var zhuyin = gridOneMain.CurrentRow.Cells[2].EditedFormattedValue.ToString();
            var traditional = gridOneMain.CurrentRow.Cells[3].EditedFormattedValue.ToString();
            var english = gridOneMain.CurrentRow.Cells[4].EditedFormattedValue.ToString();
            //var numpinyin = gridOneMain.CurrentRow.Cells[5].EditedFormattedValue.ToString();
            //var critpinyin = gridOneMain.CurrentRow.Cells[6].EditedFormattedValue.ToString();
            //var simplified = gridOneMain.CurrentRow.Cells[7].EditedFormattedValue.ToString();
            //var cji = gridOneMain.CurrentRow.Cells[8].EditedFormattedValue.ToString();

            int idint;
            var validid = Int32.TryParse(idstring, out idint);
            if (!validid)
            {
                Status.Text = @"Unable to convert row ID from string to int32. Should not have happened!";
                //return;
            }

            int baseseq;
            var validbase = Int32.TryParse(txtFEsequence.Text, out baseseq);
            if (!validbase)
            {
                Status.Text = @"F E Sequence not a valid integer. Sorry!";
                return;
            }

            int intfeseqoffset;
            var validintfeseq = Int32.TryParse(feseq, out intfeseqoffset);
            if (!validintfeseq)
            {
                Status.Text = @"Updated F E Sequence not a valid integer!. Sorry.";
                return;
            }

            using (var d3K = new Dictionary3000DataContext(Properties.Settings.Default.ChineseStudyConnection))
            {
                var trads = from q in d3K._3000_Characters
                    where q.ID == idint
                    select q;

                foreach (var trad in trads)
                {
                    if (baseseq == intfeseqoffset/100)
                    {
                        var clippedFEseq = intfeseqoffset.ToString(CultureInfo.InvariantCulture);
                        if (clippedFEseq.Length < 1 || clippedFEseq.Length > 6)
                        {
                            Status.Text = @"Updated F E Sequence not a valid length!. Sorry.";
                            return;
                        }

                        switch (clippedFEseq.Length)
                        {
                            case 1:
                                trad.FEseq = "00000" + clippedFEseq;
                                break;
                            case 2:
                                trad.FEseq = "0000" + clippedFEseq;
                                break;
                            case 3:
                                trad.FEseq = "000" + clippedFEseq;
                                break;
                            case 4:
                                trad.FEseq = "00" + clippedFEseq;
                                break;
                            case 5:
                                trad.FEseq = "0" + clippedFEseq;
                                break;
                            case 6:
                                trad.FEseq = clippedFEseq;
                                break;
                        }
                    }
                    else
                    {
                        var clippedFEseq = intfeseqoffset == 0 ? 0.ToString(CultureInfo.InvariantCulture) : ((baseseq * 100) + intfeseqoffset).ToString(CultureInfo.InvariantCulture);

                        switch (clippedFEseq.Length)
                        {
                            case 1:
                                trad.FEseq = "00000" + clippedFEseq;
                                break;
                            case 2:
                                trad.FEseq = "0000" + clippedFEseq;
                                break;
                            case 3:
                                trad.FEseq = "000" + clippedFEseq;
                                break;
                            case 4:
                                trad.FEseq = "00" + clippedFEseq;
                                break;
                            case 5:
                                trad.FEseq = "0" + clippedFEseq;
                                break;
                            case 6:
                                trad.FEseq = clippedFEseq;
                                break;
                        }
                    }

                    trad.Zhuyin = zhuyin;
                    trad.Traditional = traditional;
                    trad.English = english;
                    //trad.NumPinyin = numpinyin;
                    //trad.CritPinyin = critpinyin;
                    //trad.Simplified = simplified;
                    //trad.Cji = cji;

                    d3K.SubmitChanges();
                }
            }

            gridOneMain.Rows.Clear();

            using (var d3K = new Dictionary3000DataContext(Properties.Settings.Default.ChineseStudyConnection))
            {
                var trads = from q in d3K._3000_Characters
                    where q.Traditional.Contains(txtMainCharacter.Text)
                    orderby q.FEseq
                    select q;
                    
                foreach (var trad in trads)
                {
                    var fePrefix = txtFEsequence.Text;
                    var feFull = trad.FEseq.ToString(CultureInfo.InvariantCulture);
                    var fePrefixLength = fePrefix.Length;

                    if (!chkByPass.Checked && trad.FEseq != "0" &&
                        ((feFull.Substring(0, fePrefixLength) != fePrefix) || (feFull.Length != fePrefixLength + 2)))
                        continue;
                    object[] row =
                    {
                        trad.ID.ToString(CultureInfo.InvariantCulture), trad.FEseq, trad.Zhuyin,
                        trad.Traditional, trad.English, trad.NumPinyin, trad.CritPinyin, trad.Simplified,
                        trad.Cji
                    };
                    gridOneMain.Rows.Add(row);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMainCharacter_Click(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = _myLanguages[Properties.Settings.Default.Studying];
            txtMainCharacter.ImeMode = ImeMode.On;
        }

        private void txtFEsequence_Click(object sender, EventArgs e)
        {
            txtFEsequence.Text = "";
            txtMainCharacter.Text = "";
            InputLanguage.CurrentInputLanguage = _myLanguages[Properties.Settings.Default.Know];
        }

        private void txtMainCharacter_Enter(object sender, EventArgs e)
        {
            txtFEsequence.Text = "";
            txtMainCharacter.Text = "";
            InputLanguage.CurrentInputLanguage = _myLanguages[Properties.Settings.Default.Studying];
            txtMainCharacter.ImeMode = ImeMode.On;
        }

        private void btnSetUserCredentials_Click(object sender, EventArgs e)
        {
            var setUserCredentialsForm = new SetUserCredentials();
            setUserCredentialsForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRow();
        }

        private void btnFindMain_Click(object sender, EventArgs e)
        {
            if (txtFEsequence.Text == "") return;
            
            var mainId = txtFEsequence.Text + @"01";
            using (var d3K = new Dictionary3000DataContext(Properties.Settings.Default.ChineseStudyConnection))
            {
                var trads = from q in d3K._3000_Characters
                            where q.FEseq == mainId
                            select q;

                foreach (var trad in trads)
                {
                    txtMainCharacter.Text = trad.Traditional;
                    break;
                }
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            var Sane = false;
            do
            {
                int ScanSequence;
                var validid = Int32.TryParse(txtFEsequence.Text, out ScanSequence);
                if (!validid)
                {
                    Status.Text = @"Unable to convert FEseq from string to int32. Should not have happened!";
                    return;
                }

                ScanSequence++;
                txtFEsequence.Text = ScanSequence.ToString(CultureInfo.InvariantCulture);
                txtMainCharacter.Text = @"";

                var mainId = txtFEsequence.Text + @"01";
                using (var d3K = new Dictionary3000DataContext(Settings.Default.ChineseStudyConnection))
                {
                    var trads = from q in d3K._3000_Characters
                        where q.FEseq == mainId
                        select q;

                    foreach (var trad in trads)
                    {
                        txtMainCharacter.Text = trad.Traditional;
                        break;
                    }

                    gridOneMain.Rows.Clear();

                    using (var d4K = new Dictionary3000DataContext(Settings.Default.ChineseStudyConnection))
                    {
                        IOrderedQueryable<_3000_Character> strads;
                        if (!chkByPass.Checked)
                        {
                            strads = from q in d4K._3000_Characters
                                where (q.Traditional.Contains(txtMainCharacter.Text) /* && q.FEseq == "0" */)
                                orderby q.FEseq
                                select q;
                        }
                        else
                        {
                            strads = from q in d4K._3000_Characters
                                where q.Traditional.Contains(txtMainCharacter.Text)
                                orderby q.FEseq
                                select q;
                        }
                        gridOneMain.SelectAll();

                        var FiftyFound = false;
                        txtFound.Text = @"";

                        var fePrefix = txtFEsequence.Text;
                        var fePrefixLength = fePrefix.Length;
                        foreach (var trad in strads)
                        {
                            var feFull = trad.FEseq.ToString(CultureInfo.InvariantCulture);
                            if (!chkByPass.Checked && trad.FEseq != "0" &&
                                (((feFull.Length != fePrefixLength + 2)) || (feFull.Substring(0, fePrefixLength) != fePrefix)) &&
                                (((feFull.Length != fePrefixLength)) || (feFull != fePrefix))) continue;

                            if (feFull.Substring(feFull.Length - 2, 2) == @"50") FiftyFound = true;
                            if (FiftyFound) txtFound.Text = txtFound.Text + feFull.Substring(feFull.Length - 1, 1);

                            object[] row = { trad.ID.ToString(CultureInfo.InvariantCulture), trad.FEseq, trad.Zhuyin, trad.Traditional, trad.English, trad.NumPinyin, trad.CritPinyin, trad.Simplified, trad.Cji };
                            gridOneMain.Rows.Add(row);
                        }

                    }

                    ScanSequence++;
                }

                Sane = false;

                if (txtFound.Text.Length == 0 && txtFound.Text == @"") Sane = true;
                if (txtFound.Text.Length == 1 && txtFound.Text == @"0") Sane = true;
                if (txtFound.Text.Length == 2 && txtFound.Text == @"01") Sane = true;
                if (txtFound.Text.Length == 3 && txtFound.Text == @"012") Sane = true;
                if (txtFound.Text.Length == 4 && txtFound.Text == @"0123") Sane = true;
                if (txtFound.Text.Length == 5 && txtFound.Text == @"01234") Sane = true;
                if (txtFound.Text.Length == 6 && txtFound.Text == @"012345") Sane = true;
                if (txtFound.Text.Length == 7 && txtFound.Text == @"0123456") Sane = true;
            } while (Sane);
        }

        private void ShowLanguages_Click(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = _myLanguages[Properties.Settings.Default.Know];
            var showLanguagesForm = new InstalledLangs();
            showLanguagesForm.ShowDialog();
        }

        private void gridOneMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridOneMain.CurrentCell.ColumnIndex == 2 || gridOneMain.CurrentCell.ColumnIndex == 3)
            {
                InputLanguage.CurrentInputLanguage = _myLanguages[Properties.Settings.Default.Studying];
                gridOneMain.ImeMode = ImeMode.On;
            }
            else
            {
                {
                    InputLanguage.CurrentInputLanguage = _myLanguages[Properties.Settings.Default.Know];
                    gridOneMain.ImeMode = ImeMode.Off;
                }
            }
        }

        private void txtFEsequence_Enter(object sender, EventArgs e)
        {
            txtFEsequence.Text = "";
            InputLanguage.CurrentInputLanguage = _myLanguages[Properties.Settings.Default.Know];
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = _myLanguages[Properties.Settings.Default.Know];
        }

        private void txtFound_TextChanged(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = _myLanguages[Properties.Settings.Default.Know];
        }

        private void Status_TextChanged(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = _myLanguages[Properties.Settings.Default.Know];
        }
    }
}
