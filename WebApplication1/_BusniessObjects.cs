using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using eteach.Toolkit.BaseClasses;

namespace WebApplication1
{
    public class _BusniessObjects : eteach.Toolkit.BaseClasses.BusinessObject
    {
        public _BusniessObjects(Context context)
            : base(context, "_BusniessObjects")
        {
        }

        public void Detail(ref DataSet dataSet, Int32 personneId)
        {
            _DataAccess personne = new _DataAccess(base.Context);
            personne.Detail(ref dataSet, personneId);
            personne.Dispose();
        }

        public void List(ref DataSet dataSet)
        {
            _DataAccess personne = new _DataAccess(base.Context);
            personne.List(ref dataSet);
            personne.Dispose();
        }
    }
}