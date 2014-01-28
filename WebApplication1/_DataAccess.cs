using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using eteach.Toolkit.BaseClasses;

namespace WebApplication1
{
    public class _DataAccess : DataAccess
    {
        public _DataAccess(Context context)
            : base(context, "_DataAccess", "ConnectionString")
        {
        }
        /// <summary>
        /// Donne le détail d'une personne
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="pesonneId"></param>
        public void Detail(ref DataSet dataSet, Int32 pesonneId)
        {
            IDbCommand iDbCommand = CreateCommand("SELECT * FROM Personne WHERE PersonneId = @PersonneId");
            iDbCommand.CommandType = CommandType.Text;
            iDbCommand.Parameters.Add(this.CreateParameter("@PersonneId", pesonneId));
            this.Fill(dataSet, "Personne", iDbCommand);
        }

        /// <summary>
        /// Donne la liste de toutes les personnes
        /// </summary>
        /// <param name="dataSet"></param>
        public void List(ref DataSet dataSet)
        {
            IDbCommand iDbCommand = CreateCommand("SELECT * FROM Personne");
            iDbCommand.CommandType = CommandType.Text;
            this.Fill(dataSet, "Personne", iDbCommand);
        }

        /// <summary>
        /// Recherche une personne sur base du nom
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="nom"></param>
        public void Search(ref DataSet dataSet, string nom)
        {
            IDbCommand iDbCommand = CreateCommand("SELECT * FROM Personne WHERE Nom LIKE @Nom");
            iDbCommand.CommandType = CommandType.Text;
            iDbCommand.Parameters.Add(this.CreateParameter("@Nom", nom));
            this.Fill(dataSet, "Personne", iDbCommand);
        }

        /// <summary>
        /// Sauvegarde des records
        /// </summary>
        /// <param name="dataSet"></param>
        public void Save(ref DataSet dataSet)
        {
        }

        /// <summary>
        /// Suppression du record
        /// </summary>
        /// <param name="pesonneId"></param>
        public void Delete(Int32 pesonneId)
        {
            IDbCommand iDbCommand = CreateCommand("DELETE Personne WHERE PersonneId = @PersonneId");
            iDbCommand.CommandType = CommandType.Text;
            iDbCommand.Parameters.Add(this.CreateParameter("@PersonneId", pesonneId));
            this.ExecuteNonQuery(iDbCommand);
        }
    }
}