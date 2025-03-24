
using MySql.Data.MySqlClient;

namespace Lernmaschine
{
    internal class Model : IModel
    {
        private static string myConnectionString = "server=127.0.0.1;uid=lernmaschine;pwd=lernenHHBK;database=lernmaschine;";
        private static MySqlConnection conn=new MySqlConnection(myConnectionString);
        private static MySqlCommand mycommand=conn.CreateCommand();
        private MySqlDataReader myDataReader;

        private IView view;
        private IController controller;
        IView IModel.View { set
            { 
                view = value;
                view.anzeigen((this as  IModel).suchen(new Karteikarte()));
            }
        }
        IController IModel.Controller { set => controller=value; }

        public Model()
        {
            createDB();
            createTestData();
        }

        void IModel.aendern(Karteikarte karteikarte)
        {
            throw new NotImplementedException();
        }

        void IModel.einfuegen(Karteikarte karteikarte)
        {
            if (karteikarte.Karteikartennummer != -1)
            {
                mycommand.CommandText = "REPLACE INTO Karteikarten " +
                    "VALUES (" +
                    "'"+karteikarte.Karteikartennummer+"'," +
                    "'" + karteikarte.Unterrichtsfach+"'," +
                    "'" + karteikarte.Thema+"',"+
                    "'" + karteikarte.Fach+"',"+
                    "'" + karteikarte.Vorderseite+"',"+
                    "'" + karteikarte.Rueckseite+"'"+
                    ");";

                conn.Open();
                mycommand.ExecuteNonQuery();
                conn.Close();
            }

            else
            {
                mycommand.CommandText = "INSERT INTO Karteikarten " +
                    "VALUES (" +
                    "'NULL'," +
                    "'" + karteikarte.Unterrichtsfach + "'," +
                    "'" + karteikarte.Thema + "'," +
                    "'" + karteikarte.Fach + "'," +
                    "'" + karteikarte.Vorderseite + "'," +
                    "'" + karteikarte.Rueckseite + "'" +
                    ");";

                conn.Open();
                mycommand.ExecuteNonQuery();
                conn.Close();
                view.anzeigen((this as IModel).suchen(new Karteikarte()));
            }
        }

    

        void IModel.loeschen(Karteikarte karteikarte)
        {
            mycommand.CommandText = "DELETE FROM Karteikarten " +
                   "WHERE Karteikartennummer=" +
                   "'" + karteikarte.Karteikartennummer + "';";

            conn.Open();
            mycommand.ExecuteNonQuery();
            conn.Close();
            view.anzeigen((this as IModel).suchen(new Karteikarte()));
        }

        List<Karteikarte> IModel.suchen(Karteikarte karteikarte)
        {
            List<Karteikarte> ergebnis=new List<Karteikarte>();
            Karteikarte aktuelleKarte;
            try
            {
                mycommand.CommandText = "SELECT * from karteikarten;";

                conn.Open();
                myDataReader = mycommand.ExecuteReader();
                while (myDataReader.Read())
                {
                    aktuelleKarte = new Karteikarte();
                    aktuelleKarte.Karteikartennummer = myDataReader.GetInt32("Karteikartennummer");
                    aktuelleKarte.Unterrichtsfach = myDataReader.GetString("Unterrichtsfach");
                    aktuelleKarte.Thema = myDataReader.GetString("Thema");
                    aktuelleKarte.Fach = myDataReader.GetString("Fach");
                    aktuelleKarte.Vorderseite = myDataReader.GetString("Vorderseite");
                    aktuelleKarte.Rueckseite = myDataReader.GetString("Rueckseite");
                    ergebnis.Add( aktuelleKarte );

                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);

                
            }
            finally
            {
                conn.Close();
            }
            return ergebnis;
        }

        #region DB
        private void createDB()
        {
            try
            {
                mycommand.CommandText = Commands.CreateDatabase;

                conn.Open();
                mycommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

                //return false;
            }
            finally
            {
                conn.Close();
                conn.ConnectionString = myConnectionString;
            }

            //return true;

        }

        private bool createTestData()
        {
            try
            {
                mycommand.CommandText = Commands.CreateTestdata;

                conn.Open();
                mycommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);

                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;

        }
#endregion
    }
}