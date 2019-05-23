using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BL;
using Model;
namespace Three_Layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            tblUserBindingSource.EndEdit();
            TblUser user = tblUserBindingSource.Current as TblUser;
            //TblUser user =(TblUser) tblUserBindingSource.Current;
          int result=  UserRepositroy.Insert(user);

           Func<int,int,int>=(a,b)=> a + b;

        }

        int Getlist(int a,int b)
        {
           return a + b;
        }

    }
}
