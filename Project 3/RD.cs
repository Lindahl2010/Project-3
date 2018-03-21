using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_3
{
    public partial class RD : Form
    {
        public RD()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(0);
        }

        private void backBtn2_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(0);
        }

        private void newRdntBtn_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(1);
        }

        private void rdntSearchBtn_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(2);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static List<Student> ReadData()
        {
            List<Student> students = new List<Student>();
            const string FILE = "Residence Hall.csv";
            const char DELIM = ',';
            string[] info;

            try
            {
                FileStream file = new FileStream(FILE, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);

                while (!reader.EndOfStream)
                {
                    info = reader.ReadLine().Split(DELIM);


                }

                reader.Close();
                file.Close();

            }
            catch
            {
                
            }

            return students;
        }
    }

    public abstract class Student : IRDFunctions
    {
        public int idNum { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public int dormNum { get; set; }
        public int floor { get; set; }
        public int rent { get; set; }

        public Student()
        {

        }
        
        public Student(int idNum, string fname, string lname, int dormNum, int floor, int rent)
        {
            this.idNum = idNum;
            this.fname = fname;
            this.lname = lname;
            this.dormNum = dormNum;
            this.floor = floor;
            this.rent = rent;
        }

        public abstract int Balance();
    }

    interface IRDFunctions
    {
        int Balance();
    }
}
