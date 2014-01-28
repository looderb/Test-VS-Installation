using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using eteach.Toolkit.BaseClasses;

namespace WebApplication1
{
    internal class _BusniessObjects : eteach.Toolkit.BaseClasses.BusinessObject
    {
        public _BusniessObjects(Context context)
            : base(context, "_BusniessObjects")
        {
        }

        /// <summary>
        /// Donne le détail d'une personne
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="personneId"></param>
        public void Detail(ref DataSet dataSet, Int32 personneId)
        {
            _DataAccess personne = new _DataAccess(base.Context);
            personne.Detail(ref dataSet, personneId);
            personne.Dispose();
        }

        /// <summary>
        /// Donne la liste de toutes les personnes
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="nom"></param>
        public void Search(ref DataSet dataSet, string nom)
        {
            _DataAccess personne = new _DataAccess(base.Context);
            personne.Search(ref dataSet, nom);
            personne.Dispose();
        }

        /// <summary>
        /// Recherche une personne sur base du nom
        /// </summary>
        /// <param name="dataSet"></param>
        public void List(ref DataSet dataSet)
        {
            _DataAccess personne = new _DataAccess(base.Context);
            personne.List(ref dataSet);
            personne.Dispose();
        }

        /// <summary>
        /// Sauvegarde des records
        /// </summary>
        /// <param name="dataSet"></param>
        public void Save(ref DataSet dataSet)
        {
            _DataAccess personne = new _DataAccess(base.Context);
            personne.Save(ref dataSet);
            personne.Dispose();
        }

        /// <summary>
        /// Suppression du record
        /// </summary>
        /// <param name="personneId"></param>
        public void Delete(Int32 personneId)
        {
            _DataAccess personne = new _DataAccess(base.Context);
            personne.Delete(personneId);
            personne.Dispose();
        }
    }
}