using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

using System.Collections.Generic;

namespace PostgresCode
{
    public enum TypeServer :byte
    {
        ServerPostgres,
        ServerSQL
    }

    // POCO class
    //[Table(name: "Sprinters", Schema = "public")]
    public class CPerson
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public float age { get; set; }
        public string city { get; set; }
        public float height { get; set; }
    }

    public class PeopleDBContext : DbContext
    {
        #region - Variables ------------------------
        //(Database context)
        public DbSet<CPerson> dbPersons { get; set; } //ten Lud2 to pole w klasie [PeopleDBContext]

        private string sSchema;
        private string sTableName;

        public string csConnString { get; set; }
        public bool cbConnectionExist { get; set; }

        #endregion -----------

        #region - Constructor operations -----------

        public PeopleDBContext(string xConnString, string xsSchema, string xsTableName)
            : base(nameOrConnectionString: xConnString )
        {
            sSchema = xsSchema;
            sTableName = xsTableName;
            csConnString = xConnString;
            cbConnectionExist = Database.Exists(); //(csConnString);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema(sSchema);
            modelBuilder.Entity<CPerson>().ToTable(sTableName, sSchema);
            base.OnModelCreating(modelBuilder);
        }

        #endregion -----------

        #region - Methods-Operations ---------------

        public void AddOnePerson(string xsName, string xsSurname, 
                                 float xfAge, string xsCity, float xfHeight)
        {
            //temporary POCO class
            CPerson aLud = new CPerson 
            {
                //Id = 1,
                name = xsName,
                surname = xsSurname,
                age = xfAge,
                city = xsCity,
                height = xfHeight
            };

            AddAlbum(aLud); //Added aLud to dbPersons
            SaveChanges();  //Save changes
        }

        public void AddAlbum(CPerson xLud)
        {
            dbPersons.Add(xLud);
        }

        public void RemoveAlbum(int xId)
        {
            var person1 = new CPerson() { Id = xId };
            dbPersons.Remove(dbPersons.Find(xId));
            SaveChanges();  //Save changes
        }

        public string GetConnString()
        {
            return (csConnString);
        }

        #endregion -----------
    }
}
