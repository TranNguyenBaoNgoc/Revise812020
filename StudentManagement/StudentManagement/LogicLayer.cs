using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class LogicLayer
    {
        public STUDENT[] getStudents()
        {
            var db = new MyDatabaseEntities();
            return db.STUDENTs.ToArray();
        }

        public STUDENT GetStudent(int id)
        {
            var db = new MyDatabaseEntities();
            var stu = db.STUDENTs.Find(id);
            return stu;
        }

        public CLASS[] GetClasses()
        {
            var db = new MyDatabaseEntities();
            return db.CLASSes.ToArray();
        }

        public void CreateStudent(string name, bool gender, DateTime birth, int class_id)
        {
            var stu = new STUDENT();
            stu.FULLNAME = name;
            stu.GENDER = gender;
            stu.BIRTHDAY = birth;
            stu.CLASS_ID = class_id;

            var db = new MyDatabaseEntities();
            db.STUDENTs.Add(stu);
            db.SaveChanges();
        }

        public void UpdateStudent(int id, string name, bool gender, DateTime birth, int class_id)
        {
            var db = new MyDatabaseEntities();
            var stu = db.STUDENTs.Find(id);

            stu.FULLNAME = name;
            stu.GENDER = gender;
            stu.BIRTHDAY = birth;
            stu.CLASS_ID = class_id;

            db.Entry(stu).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var db = new MyDatabaseEntities();
            var stu = db.STUDENTs.Find(id);

            db.STUDENTs.Remove(stu);
            db.SaveChanges();
        }
    }
}
