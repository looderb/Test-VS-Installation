﻿using System;
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

        public void Detail(ref DataSet dataSet, Int32 pesonneId)
        {
            IDbCommand iDbCommand = CreateCommand("SELECT * FROM Personne WHERE PersonneId = @PersonneId");
            iDbCommand.CommandType = CommandType.Text;
            iDbCommand.Parameters.Add(this.CreateParameter("@PersonneId", pesonneId));
            this.Fill(dataSet, "Personne", iDbCommand);
        }

        public void List(ref DataSet dataSet)
        {
            IDbCommand iDbCommand = CreateCommand("SELECT * FROM Personne");
            iDbCommand.CommandType = CommandType.Text;
            this.Fill(dataSet, "Personne", iDbCommand);
        }

        public void Search(ref DataSet dataSet, string nom)
        {
            IDbCommand iDbCommand = CreateCommand("SELECT * FROM Personne WHERE Nom LIKE @Nom");
            iDbCommand.CommandType = CommandType.Text;
            iDbCommand.Parameters.Add(this.CreateParameter("@Nom", nom));
            this.Fill(dataSet, "Personne", iDbCommand);
        }

        public void Save(ref DataSet dataSet)
        {
        }

        public void Delete(Int32 pesonneId)
        {
            IDbCommand iDbCommand = CreateCommand("DELETE Personne WHERE PersonneId = @PersonneId");
            iDbCommand.CommandType = CommandType.Text;
            iDbCommand.Parameters.Add(this.CreateParameter("@PersonneId", pesonneId));
            this.ExecuteNonQuery(iDbCommand);
        }
    }
}