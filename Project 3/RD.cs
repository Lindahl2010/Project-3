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
        List<Student> studentList = new List<Student>();

        public RD()
        {
            InitializeComponent();

            studentList = readData();

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
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string idNumber = idSearchBox.Text;

            var stdntFile =
                from stdnt in studentList
                where stdnt.idNum == Convert.ToInt32(idNumber)
                select new { stdnt.idNum, stdnt.fname, stdnt.lname, stdnt.floor, stdnt.dormNum, stdnt.rent };

            foreach (var stdnt in stdntFile)
            {
                label5.Text = Convert.ToString(stdnt.idNum);
                label6.Text = stdnt.fname;
                label7.Text = stdnt.lname;
                label8.Text = Convert.ToString(stdnt.dormNum);
                label9.Text = Convert.ToString(stdnt.floor);
                label10.Text = Convert.ToString(stdnt.rent);
            }
        }

        private void idSearchBox_TextChanged(object sender, EventArgs e)
        {
            idSearchBox.MaxLength = 4;
        }

        private void scholarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void athleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void stdntCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        public static List<Student> readData()
        {

            List<Student> students = new List<Student>();
            Scholar scholar;
            Athlete athlete;
            Worker worker;
            const string FILE = "Residence Hall.csv";
            const char DELIM = ',';
            string[] info;

            try
            {

                FileStream file = new FileStream(FILE, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string headerLine = reader.ReadLine();

                while (!reader.EndOfStream)
                {

                    info = reader.ReadLine().Split(DELIM);

                    switch (info[6])
                    {
                        case "Scholar":
                            scholar = new Scholar(Convert.ToInt32(info[0]), info[1], info[2], Convert.ToInt32(info[3]), Convert.ToInt32(info[4]), Convert.ToInt32(info[5]), info[6]);
                            Console.WriteLine(scholar);
                            students.Add(scholar);
                            break;
                        case "Athlete":
                            athlete = new Athlete(Convert.ToInt32(info[0]), info[1], info[2], Convert.ToInt32(info[3]), Convert.ToInt32(info[4]), Convert.ToInt32(info[5]), info[6]);
                            Console.WriteLine(athlete);
                            students.Add(athlete);
                            break;
                        case "Worker":
                            worker = new Worker(Convert.ToInt32(info[0]), info[1], info[2], Convert.ToInt32(info[3]), Convert.ToInt32(info[4]), Convert.ToInt32(info[5]), info[6]);
                            Console.WriteLine(worker);
                            students.Add(worker);
                            break;
                    }
                }

                reader.Close();
                file.Close();

            }
            catch(Exception i)
            {
                Console.WriteLine(i.Message);
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
        public string studentGroup { get; set; }

        public Student()
        {

        }
        
        public Student(int idNum, string fname, string lname, int dormNum, int floor, int rent, string stdntGroup)
        {
            this.idNum = idNum;
            this.fname = fname;
            this.lname = lname;
            this.dormNum = dormNum;
            this.floor = floor;
            this.rent = rent;
            studentGroup = stdntGroup;
        }

        public abstract int Balance();
    }

    interface IRDFunctions
    {
        int Balance();
    }
}
