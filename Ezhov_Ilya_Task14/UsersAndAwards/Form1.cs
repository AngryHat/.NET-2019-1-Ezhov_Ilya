using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersAndAwards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            User user1 = new User("Ivan", "Ruka", DateTime.Parse("1989.11.23"));
            User user2 = new User("Roman", "Zhukov", DateTime.Parse("1999.02.11"));
            User user3 = new User("Alena", "Apina", DateTime.Parse("1987.03.08"));
            User user4 = new User("Vasyliy", "Erohin", DateTime.Parse("1963.08.14"));

            InitializeComponent();
        }
    }
}
