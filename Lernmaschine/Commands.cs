namespace Lernmaschine
{
    internal class Commands
    {
        private static String createDatabase =
            "CREATE DATABASE IF NOT EXISTS `Lernmaschine` DEFAULT CHARACTER SET utf8; " +
            "USE `Lernmaschine`; " +

            "CREATE TABLE IF NOT EXISTS `Karteikarten` ( " +
            "`Karteikartennummer` INT NOT NULL AUTO_INCREMENT, " +
            "`Unterrichtsfach` VARCHAR(45) NULL, " +
            "`Thema` VARCHAR(45) NULL, " +
            "`Fach` VARCHAR(45) NULL, " +
            "`Vorderseite` VARCHAR(200) NULL, " +
            "`Rueckseite` VARCHAR(200) NULL, " +
            "PRIMARY KEY(`Karteikartennummer`)) " +
            "ENGINE = InnoDB; ";
        /*
        +
        "CREATE USER 'erpModel'@'localhost' IDENTIFIED VIA mysql_native_password USING '555HHBK';"+
        "GRANT SELECT, INSERT, UPDATE, DELETE, CREATE, DROP, FILE, INDEX, ALTER, CREATE TEMPORARY TABLES,"+
        "CREATE VIEW, EVENT, TRIGGER, SHOW VIEW, CREATE ROUTINE, ALTER ROUTINE, EXECUTE ON*.* TO 'erpModel'@'localhost'"+
        "REQUIRE NONE WITH MAX_QUERIES_PER_HOUR 0 MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0;";
        */
        public static String CreateDatabase { get => createDatabase; }

        private static String createTestdata =
            "INSERT INTO Karteikarten " +
            "VALUES " +
            //`Karteikartennummer`,`Unterrichtsfach`,`Thema`,`Fach`,`Vorderseite`,`Rueckseite`
            "(10001, \"SOFT\", \"OOP\",\"1\", \"Kapselung\"  ,\"Zugriff auf private Attribute über geter/seter oder Schreib-/Leseeigenschaften\"), " +
            "(22000, \"SOFT\", \"OOP\",\"1\", \"Eigenschaft\",\"C# für geter und seter\"), " +
            "(30303, \"SOFT\", \"OOP\",\"2\", \"Vererbung\"  ,\"Beziehung von Superklasse bzw. Basisklasse zu Klasse\"), " +
            "(40440, \"SOFT\", \"OOP\",\"3\", \"Überladen\"  ,\"Methoden mit dem selben Namen und anderen Parametern (Anzahl und oder Datentyp)\");"
            ;

        public static String CreateTestdata { get => createTestdata; }
        public static string GetProduktIDandName { get => getProduktIDandName; set => getProduktIDandName = value; }

        private static String getProduktIDandName = "SELECT * FROM produkt";

        //public static string newEntity(Karteikarte k)
        //{
        //    /*
        //    MessageBox.Show("UPDATE produkt SET " +
        //        "artikelname='" + p.Artikelname +"', "+
        //        "verkaufseinheit='" + p.Verkaufseinheit + "', "+
        //        "einheit='" + p.Einheit + "', "+
        //        "preisVK='" + p.PreisVK + "', "+
        //        "chemischeBezeichnung='" +p.ChemischeBezeichnung + "' "+
        //        "WHERE artikelnummer='" + p.Artikelnummer + "';");
        //    */
        //    //return "INSERT INTO produkt VALUES( " +
        //    //    "NULL, '" +
        //    //    p.Artikelname + "', '" +
        //    //    p.Verkaufseinheit + "', '" +
        //    //    p.Einheit + "', '" +
        //    //    p.PreisVK + "', '" +
        //    //    p.ChemischeBezeichnung + "'); ";
        //}
        //public static string change(Karteikarte k)
        //{
        //    /*
        //    MessageBox.Show("UPDATE produkt SET " +
        //        "artikelname='" + p.Artikelname +"', "+
        //        "verkaufseinheit='" + p.Verkaufseinheit + "', "+
        //        "einheit='" + p.Einheit + "', "+
        //        "preisVK='" + p.PreisVK + "', "+
        //        "chemischeBezeichnung='" +p.ChemischeBezeichnung + "' "+
        //        "WHERE artikelnummer='" + p.Artikelnummer + "';");
        //    */
        //    return "UPDATE produkt SET " +
        //        "artikelname='" + p.Artikelname + "', " +
        //        "verkaufseinheit='" + p.Verkaufseinheit + "', " +
        //        "einheit='" + p.Einheit + "', " +
        //        "preisVK='" + p.PreisVK + "', " +
        //        "chemischeBezeichnung='" + p.ChemischeBezeichnung + "' " +
        //        "WHERE artikelnummer='" + p.Artikelnummer + "';";
        //}

        //public static string delete(Karteikarte k)
        //{
        //    //MessageBox.Show("Artikelnummer:"+ p.Artikelnummer);

        //    return "DELETE from produkt WHERE artikelnummer=" + p.Artikelnummer + ";";
        //}

        

    }

}