using System.Drawing.Imaging;
namespace Lab6
{
    public partial class Form1 : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        public Pen pen = new Pen(Color.Black, 5);
        public Graphics g ;
        Bitmap Surface;
        Graphics Grap;
        string S = "/image";
        int i =  1;

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            Surface = new Bitmap(panel1.Width, panel1.Height);
            Grap = Graphics.FromImage(Surface);
            panel1.BackgroundImage = Surface;
            panel1.BackgroundImageLayout = ImageLayout.None;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
            if (rdb_1.Checked)
            {
                pen.Width = 1;
            }
            if (rdb_2.Checked)
            {
                pen.Width = 10;
            }
            if (rdb_3.Checked)
            {
                pen.Width = 20;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                Grap.DrawLine(pen, old, current);
                
                old = current;
                panel1.Invalidate();
            }
        }

        private void bt_colour_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog.Color;
            }
        }

        private void bt_end_Click(object sender, EventArgs e)
        {
            string path = "";
            using (FolderBrowserDialog folder = new FolderBrowserDialog())
            {
                if (folder.ShowDialog() == DialogResult.OK)
                    path = folder.SelectedPath;
            }    

                Surface.Save(path + S + ".png", ImageFormat.Png);
            S += i;
            i++;

        }
    }
}