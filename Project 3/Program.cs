using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DunwoodyRH());
        }
    }

    class Scholar : Student
    {
        public Scholar(int idNum, string fname, string lname, int dormNum, int floor, int rent, string stdntGroup) : base(idNum, fname, lname, dormNum, floor, rent, stdntGroup)
        {
            this.idNum = idNum;
            this.fname = fname;
            this.lname = lname;
            this.dormNum = dormNum;
            this.floor = floor;
            this.rent = rent;
        }

        public override int Balance()
        {
            return rent;
        }
    }

    class Athlete : Student
    {
        public Athlete(int idNum, string fname, string lname, int dormNum, int floor, int rent, string stdntGroup) : base(idNum, fname, lname, dormNum, floor, rent, stdntGroup)
        {
            this.idNum = idNum;
            this.fname = fname;
            this.lname = lname;
            this.dormNum = dormNum;
            this.floor = floor;
            this.rent = rent;
        }

        public override int Balance()
        {
            return rent;
        }
    }

    class Worker : Student
    {
        public Worker(int idNum, string fname, string lname, int dormNum, int floor, int rent, string stdntGroup) : base(idNum, fname, lname, dormNum, floor, rent, stdntGroup)
        {
            this.idNum = idNum;
            this.fname = fname;
            this.lname = lname;
            this.dormNum = dormNum;
            this.floor = floor;
            this.rent = rent;
        }

        public override int Balance()
        {
            return rent;
        }
    }

}
