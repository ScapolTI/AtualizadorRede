using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scapol.Atualizador.Rede
{
    public partial class Form1 : Form
    {
        string Usuario;
        string cnStr;
        string cnStrSQL;
        string tSQL;
        string UserSAP;
        string SenhaSAP;
        long lConexao = 1;
        int lErrCode;
        string sErrMsg;
        object rowsAffected;
        int totalLinhas = 0;
        int contador = 1;

        SAPbobsCOM.Company oCompany;

        ADODB.Connection cn;
        ADODB.Recordset rs;
        ADODB.Command cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new ADODB.Connection();
            rs = new ADODB.Recordset();


            Usuario = WindowsIdentity.GetCurrent().Name.Replace(@"SCAPOL\", "");
            Usuario = WindowsIdentity.GetCurrent().Name.Replace(@"SCAPOL\", "");

            //string de conexão
            cnStr = "DSN=hanab1; UID=SYSTEM; PWD=h1n1Sc1p4l";

            cn.Open(cnStr);

            tSQL = $@" Select ""U_usersap"",""U_senhasap"" from SBH_SCAPOL.""@TBUSUARIOS"" t where t.""U_userwindows"" = '" + Usuario + "' ";

            cn.CommandTimeout = 360;
            rs = cn.Execute(tSQL, out rowsAffected);

            if (!rs.EOF)
            {
                UserSAP = rs.Fields["u_usersap"].Value.ToString();
                SenhaSAP = rs.Fields["u_senhasap"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Usuário Windows não mapeado com usuário SAP - SBH_SCAPOL.@TBUSUARIOS");
            }

            cn.Close();

            sttlblMensagemErro.Text = "Aguarde alguns segundos enquanto a conexão é efetuada.";
            Refresh();

            oCompany = new SAPbobsCOM.Company();

            oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_HANADB;

            oCompany.Disconnect();
            oCompany.Server = "NDB@hanab1:30013";
            oCompany.UseTrusted = false;
            oCompany.DbUserName = "SYSTEM";
            oCompany.DbPassword = "h1n1Sc1p4l";
            oCompany.CompanyDB = "SBH_SCAPOL";
            oCompany.UserName = UserSAP;
            oCompany.Password = SenhaSAP;

            lConexao = oCompany.Connect();

            if (lConexao != 0)
            {
                oCompany.GetLastError(out lErrCode, out sErrMsg);
                MessageBox.Show("Não foi possível estabelecer a conexão!" + Environment.NewLine + "Por favor tentar novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sttlblMensagemErro.Text = "Erro ao conectar: " + sErrMsg;                
            }
            else
            {
                sttlblMensagem.Text = "Conectado: " + oCompany.CompanyName;
                sttlblMensagemErro.Text = string.Empty;
            }
        }

        private void btnSelArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Arquivos CSV";
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Arquivos CSV|*.CSV";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                edtCaminhoArquivo.Text = openFileDialog.FileName;
                
                totalLinhas = File.ReadLines(openFileDialog.FileName).Count();

                lblContador.Text = $"0/{totalLinhas}";
                //btnProcessar.Enabled = true;
            }
        }
    }
}
