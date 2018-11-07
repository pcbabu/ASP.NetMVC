using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DataControl
{
    public class GroupData
    {
        GroupModel GroupModel = new GroupModel();
        GroupDB db = new GroupDB();
        public IList<GroupModel> GetAllGroupData()
        {
            return (db.GroupModel.ToList());
        }

        public GroupModel dataSet(String id, String userID, String Name)
        {
            GroupModel groupModel = new GroupModel();
            groupModel.Id = id;
            groupModel.userID = userID;
            groupModel.GroupName = Name;
            return groupModel;

        }



        public void Create(String id,String userID, String Name)
        {
            GroupModel groupModel=new GroupModel();
            groupModel.Id = id;
            groupModel.userID = userID;
            groupModel.GroupName = Name;           
            db.GroupModel.Add(groupModel);
            db.SaveChanges();
        }
        public GroupModel GetGroupDetails(String id)
        {
            return db.GroupModel.Where(x => x.Id == id).Single();
        }
        public void DeleteGroup(string id)
        {
            GroupModel groupModel = db.GroupModel.Where(x => x.Id == id).First();
            db.GroupModel.Remove(groupModel);
            db.SaveChanges();
        }
        public GroupModel Find(string id)
        {
            
            GroupModel groupModel = db.GroupModel.Find(id);
            return groupModel;

        }
       
        public void UpdateDB(String id, String userID, String Name)
        {
            GroupModel groupModel = new GroupModel();
            groupModel.Id = id;
            groupModel.userID = userID;
            groupModel.GroupName = Name;
            db.Entry(groupModel).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void dispose()
        {

            db.Dispose();
        }
    }
}
