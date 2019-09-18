using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostgresCode;

namespace WinForm
{
    public partial class Form1 : Form
    {
        #region - VARIABLE & CONSTRUCTOR -----------

        TypeServer cTServer;
        PeopleDBContext ccontext;

        public Form1()
        {
            InitializeComponent();
            cTServer = TypeServer.ServerSQL;

            labTypeOfServer.Text = "Microsoft SQL Server";
            if(cTServer == TypeServer.ServerPostgres)
                labTypeOfServer.Text = "Postgres Server";

            labTable.Text = txtTableName.Text;
            jDataLoginIni();
            tabControl1.SelectTab("tabPg3");
        }

        #endregion -----------

        #region - Operations of context ------------

        public (bool, string) jReadTableFromDataBase()
        {
            bool bEndOk = false;
            string sinfo = "";

            try
            {
                ccontext = DBContextCreate();

                BindingSource bsource = new BindingSource();
                bsource.DataSource = ccontext.dbPersons.ToList();
                dGridPostgres.DataSource = null;
                dGridPostgres.DataSource = bsource;

                CTableFormat cTableFormat = new CTableFormat();
                cTableFormat.FormatColumnGrid(ref dGridPostgres, 1);

                bEndOk = true;
                sinfo = $"A table was read from the database";
            }
            catch (Exception ex) {   
                sinfo = ex.Message; 
            }

            return (bEndOk, sinfo);
        }

        public (bool, string) jAddRowToDataBase()
        {
            bool bEndOk = false;
            string sinfo = "";

            try
            {
                ccontext = DBContextCreate();

                string asName = txtAName.Text; // "Mark";
                string asSurname = txtASurname.Text; // "Molano";
                float afAge = Convert.ToSingle(CheckComma(txtAAge.Text)); //24;
                string asCity = txtACity.Text; // "London";
                float afHeight = Convert.ToSingle(CheckComma(txtAHeight.Text)); //164.5f;

                ccontext.AddOnePerson(asName, asSurname, afAge, asCity, afHeight);
                bEndOk = true;
                sinfo = $"Added person ({asName} {asSurname}) to DataBase";
            }
            catch (Exception ex)
            {
                sinfo = ex.Message;
            }

            return (bEndOk, sinfo);
        }

        public (bool, string) jAddExampleRowsToDataBase()
        {
            bool bEndOk = false;
            string sinfo = "";

            try
            {
                ccontext = DBContextCreate();

                List<CPerson> lPersons =  ListExampleRows();

                foreach (var cperson in lPersons)
                {
                    ccontext.AddAlbum(cperson);
                    ccontext.SaveChanges();
                }

                bEndOk = true;
                sinfo = $"Added {lPersons.Count} persons to DataBase";
            }
            catch (Exception ex)
            {
                sinfo = ex.Message;
            }

            return (bEndOk, sinfo);
        }



        private List<CPerson> ListExampleRows()
        {
            List<CPerson> lPersons = new List<CPerson>
            {
                new CPerson { Id = 1, name="Patrick", surname="Johnson", age =25, city="Graz", height=175 },
                new CPerson { Id = 2, name="Marian", surname="Woronin", age =52, city="Grodzisk Maz", height=181 },
                new CPerson { Id = 3, name="Usain", surname="Bolt", age =37, city="Kingston", height=188 },
                new CPerson { Id = 4, name="Marcell", surname="Jacobs", age =31, city="Trydent", height=183 },
                new CPerson { Id = 5, name="Donovan", surname="Bailey", age =42, city="Ottawa", height=178 },
            };
            return (lPersons);
        }


        public (bool, string) jDeleteRowFromDataBase(int xiRow)
        {
            bool bEndOk = false;
            string sinfo = "";

            try
            {
                ccontext = DBContextCreate();
                ccontext.RemoveAlbum(xiRow);
                bEndOk = true;
                sinfo = $"Deleted Row ({xiRow}) from DataBase";
            }
            catch (Exception ex)
            {
                sinfo = ex.Message;
            }

            return (bEndOk, sinfo);
        }

        #endregion ----------

        #region - BUTTONS --------------------------

        //---- READ TABLE BUTTON ----
        private void butReadTb_Click(object sender, EventArgs e)
        {
            jReadTableFromDataBaseWithMessage();
        }

        //---- ADD BUTTON ----
        private void butAddPerson_Click(object sender, EventArgs e)
        {
            var (bEndOk, sinfo) = jAddRowToDataBase();
            if (bEndOk)
                jReadTableFromDataBaseWithMessage(false);
            ShowMessage(bEndOk, sinfo);
        }

        private void butAddExamples_Click(object sender, EventArgs e)
        {
            var (bEndOk, sinfo) = jAddExampleRowsToDataBase();
            if (bEndOk)
                jReadTableFromDataBaseWithMessage(false);
            ShowMessage(bEndOk, sinfo);
        }


        //---- DELETE BUTTON ----
        private void butDeleteRow_Click(object sender, EventArgs e)
        {
            int iRow = ShowMessageDeleteRow();
            if (iRow > -1)
            {
                var (bEndOk, sinfo) = jDeleteRowFromDataBase(iRow);
                if (bEndOk)
                    jReadTableFromDataBaseWithMessage(false);
                ShowMessage(bEndOk, sinfo);
            }
        }

        private void txtTableName_TextChanged(object sender, EventArgs e)
        {
            labTable.Text = txtTableName.Text;
        }

        #endregion - BUTTONS ---------------

        #region - Technical ------------------------
        private string CheckComma(string xstxt)
        {   //Have to be numeric comma: ','(comma), not '.'(dot)
            //because Convert.ToSingle(string) waiting for ','(comma) 
            return (xstxt.Replace('.', ','));
        }

        #endregion ----------

        #region - VIEW Operations ------------------

        private void jReadTableFromDataBaseWithMessage(bool xbAllMessage = true)
        {
            var (bEndOk, sinfo) = jReadTableFromDataBase();
            if (xbAllMessage || !bEndOk)
                ShowMessage(bEndOk, sinfo);
        }

        private void ShowMessage(bool xbEndOk, string xsinfo)
        {
            if (xbEndOk)
                MessageBox.Show(xsinfo, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(xsinfo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int ShowMessageDeleteRow()
        {
            if (!(dGridPostgres is null))
                if (dGridPostgres.Rows.Count > 0)
                {
                    int ai = dGridPostgres.CurrentRow.Index;
                    int aId = (int)dGridPostgres.Rows[ai].Cells["Id"].Value;

                    if (MessageBox.Show($"You want delete a row Id={aId}!\r\nAre you sure?", "Confirm delete row",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                        return (aId);

                }
            MessageBox.Show("Delete canceled", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return (-1);
        }

        #endregion ------

        #region - Prepare Connection ---------------
        private PeopleDBContext DBContextCreate()
        {
            var Params = jConnString(cTServer);
            return ( new PeopleDBContext(Params.ConnString, Params.Schema, Params.TableName) );
        }    

        private (string ConnString, string Schema, string TableName) jConnString(TypeServer xTServer)
        {
            CConnString cCStr = new CConnString();
            string asCString = "";

            string tbUser = txtUser.Text;//"sa";
            string tbSchema = txtSchema.Text; //"dbo"
            string tbTableName = txtTableName.Text;//"Sprinters";

            string tbPass = txtPass.Text;//"postgres";
            string tbDataBaseName = txtDataBase.Text;//"dbMark";

            string tbComputer = txtComp.Text; //DESKTOP-BLHJAVB
            string tbServer = txtServer.Text; //SQLEXPRESS


            asCString = cCStr.jConnectionStringS(xTServer, tbDataBaseName, tbUser, tbPass,
                    tbComputer, tbServer);

            return (asCString, tbSchema, tbTableName);
        }

        private void jDataLoginIni()
        {

            string[,] stbLog = new string[,] { 
                {"dbo", "Sprinters", "dbMark", "sa", "postgres", "PC-XEONE23", "SQLEXPRESS" }, //SQL Server
                {"public", "Sprinters", "dbMark", "Mark", "postgres", "", "" } //Postgres Server
            };

            int n = 1;
            if (cTServer == TypeServer.ServerSQL)
                n = 0;

            txtSchema.Text = stbLog[n, 0]; //"dbo"
            txtTableName.Text = stbLog[n, 1];//"Sprinters";

            txtDataBase.Text = stbLog[n, 2];//"dbMark";
            txtUser.Text = stbLog[n, 3];//"sa";
            txtPass.Text = stbLog[n, 4];//"fdfff";

            txtComp.Text = stbLog[n, 5]; //PC
            txtServer.Text = stbLog[n, 6]; //SQLEXPRESS
        }


        #endregion ------------------

        private void butCheckConnection_Click(object sender, EventArgs e)
        {
            ccontext = DBContextCreate();
            string asConnString = ccontext.GetConnString();
            bool bExist = ccontext.cbConnectionExist;
            if (bExist)
            {
                labConnectionInfo.Text = "Connection Good";
                labConnectionInfo.ForeColor = Color.Green;
            }
            else
            {
                labConnectionInfo.Text = "Connection Error";
                labConnectionInfo.ForeColor = Color.Red;
            }
        }
    }
}
