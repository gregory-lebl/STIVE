using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace StiveLourd.Data
{
    public class DataTable : System.ComponentModel.MarshalByValueComponent,
        System.ComponentModel.IListSource, System.ComponentModel.ISupportInitialize,
        System.ComponentModel.ISupportInitializeNotification, System.Runtime.Serialization.ISerializable,
        System.Xml.Serialization.IXmlSerializable
    {
        bool IListSource.ContainsListCollection => throw new NotImplementedException();

        bool ISupportInitializeNotification.IsInitialized => throw new NotImplementedException();

        event EventHandler ISupportInitializeNotification.Initialized
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        void ISupportInitialize.BeginInit()
        {
            throw new NotImplementedException();
        }

        void ISupportInitialize.EndInit()
        {
            throw new NotImplementedException();
        }

        IList IListSource.GetList()
        {
            throw new NotImplementedException();
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            throw new NotImplementedException();
        }

        void IXmlSerializable.ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        void IXmlSerializable.WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class DataAdapter : System.ComponentModel.Component, System.Data.IDataAdapter
    {
        MissingMappingAction IDataAdapter.MissingMappingAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        MissingSchemaAction IDataAdapter.MissingSchemaAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        ITableMappingCollection IDataAdapter.TableMappings => throw new NotImplementedException();

        int IDataAdapter.Fill(DataSet dataSet)
        {
            throw new NotImplementedException();
        }

        System.Data.DataTable[] IDataAdapter.FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new NotImplementedException();
        }

        IDataParameter[] IDataAdapter.GetFillParameters()
        {
            throw new NotImplementedException();
        }

        int IDataAdapter.Update(DataSet dataSet)
        {
            throw new NotImplementedException();
        }
    }
}
