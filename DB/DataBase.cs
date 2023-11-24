using DB.Model;
using System.Linq;

namespace DB
{
    public class DataBase
    {
        testingDBEntities db = new testingDBEntities();

        public info GetByID(int id)
        {
            return db.info.FirstOrDefault(x => x.id == id);
        }

        public info GetByName(string name)
        {
            return db.info.FirstOrDefault(x => x.name == name);
        }

        public void Add(int id, string message, string name)
        {
            if (!CheckID(id)) return;

            info inf = new info();
            inf.id = id;
            inf.name = name;
            inf.message = message;

            db.info.Add(inf);
            db.SaveChanges();
        }

        public void Update(int id, string newMessage)
        {
            info inf = GetByID(id);
            if (inf != null)
            {
                inf.message = newMessage;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            info inf = GetByID(id);
            if (inf != null)
            {
                db.info.Remove(inf);
                db.SaveChanges();
            }
        }

        public bool CheckID(int id)
        {
            if (db.info.FirstOrDefault(x => x.id == id) != null) return true;
            return false;
        }
    }
}
