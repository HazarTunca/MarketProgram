using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using XIV.Utils;

namespace XIV.SaveSystems
{

    public static class SaveSystem
    {
        public static void Save(ISaveable saveable, string path)
        {
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    try
                    {
                        object saveData = saveable.GetSaveData();
                        bf.Serialize(fs, saveData);
                    }
                    catch (Exception e)
                    {
                        MessageUtils.ShowError(e.Source, e.Message);
                    }
                    finally
                    {
                        fs.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageUtils.ShowError(e.Source, e.Message);
            }
        }

        public static TSaveable Load<TSaveable>(string path) where TSaveable : ISaveable
        {
            var saveable = (TSaveable)Activator.CreateInstance(typeof(TSaveable));
            if (!File.Exists(path))
            {
                return saveable;
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    saveable.Load(bf.Deserialize(fs));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return saveable;
        }
    }
}