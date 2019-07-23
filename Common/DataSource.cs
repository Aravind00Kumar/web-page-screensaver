
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dashboard.Common
{
    interface IDataSource<T>
    {
        T GetValue();
        void SetValue(T preferences);
    }
    internal class DataSource<T> : IDataSource<T>
    {
        const string DATA_FILE = @".\dashboard-settings.dat";
        private readonly IFormatter formatter;
        public DataSource()
        {
            formatter = new BinaryFormatter();
        }
        public T GetValue()
        {
            using (var stream = new FileStream(DATA_FILE, FileMode.OpenOrCreate, FileAccess.Read))
            {
                return stream.Length != 0 ? (T) formatter.Deserialize(stream) : default;
            }
        }

        public void SetValue(T preferences)
        {
            using (var stream = new FileStream(DATA_FILE, FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(stream, preferences);
            }
        }
    }
}
