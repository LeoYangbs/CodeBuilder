﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeBuilder.PhysicalDataModel
{
    public class Table : BaseTable
    {
        protected Columns _primaryKeys;

        public Table()
            : this("", "", "")
        {
        }

        public Table(string id, string displayName, string name)
            : this(id, displayName, name, string.Empty)
        {
        }

        public Table(string id, string displayName, string name, string comment)
            : base(id, displayName, name, comment)
        {
            this._mataTypeName = "table";
        }

        public Columns PrimaryKeys
        {
            get { return this._primaryKeys; }
            set { this._primaryKeys = value; }
        }
    }
}
