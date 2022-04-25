namespace Notes
{
    public partial class TextForm : Form
    {
        private string _path { get; }

        private string _folder { get; } = "Static Files";
        public TextForm(string path)
        {
            InitializeComponent();

            _path = path;

            if (!Directory.Exists(_folder))
            {
                Directory.CreateDirectory(_folder);
            }


        }

        private void TextForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TbxData.SaveFile(_path);

        }

        

        private void TextForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(_path))
            {
                TbxData.LoadFile(_path);
            }
            else
            {
                TbxData.SaveFile(_path);
                TbxData.LoadFile(_path);
            }
                
        }

        

        private void BtnBold_Click(object sender, EventArgs e)
        {
            if (TbxData.SelectionFont != null)
            {

                Font currentFont = TbxData.SelectionFont;
                FontStyle newFontStyle;

                if (TbxData.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }

                TbxData.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle
                );
            }

        }

        private void BtnFontUp_Click(object sender, EventArgs e)
        {
            if (TbxData.SelectionFont != null)
            {

                Font currentFont = TbxData.SelectionFont;
                float NewFontSize = currentFont.Size + 2;

                TbxData.SelectionFont = new Font(
                   currentFont.FontFamily,
                   NewFontSize,
                   currentFont.Style
                );
            }
        }

        private void BtnFontDown_Click(object sender, EventArgs e)
        {
            if (TbxData.SelectionFont != null)
            {

                Font currentFont = TbxData.SelectionFont;
                float NewFontSize = currentFont.Size - 2;

                TbxData.SelectionFont = new Font(
                   currentFont.FontFamily,
                   NewFontSize,
                   currentFont.Style
                );
            }
        }

        private void BtnItalic_Click(object sender, EventArgs e)
        {
            if (TbxData.SelectionFont != null)
            {

                Font currentFont = TbxData.SelectionFont;
                FontStyle newFontStyle;

                if (TbxData.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                }

                TbxData.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle
                );
            }


        }
    }
}
