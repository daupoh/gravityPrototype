using gravityPrototype.models.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gravityPrototype
{
    public partial class Form1 : Form
    {
        IGameMaster m_pServer, m_pClient;

        public Form1()
        {
            InitializeComponent();
        }
    }
}
