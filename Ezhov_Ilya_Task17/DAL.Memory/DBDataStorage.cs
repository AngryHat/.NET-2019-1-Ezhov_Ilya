using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entities;
using System.Configuration;

namespace DAL.Memory
{
    public class DBDataStorage : IStorage
    {
        public DBDataStorage()
        {
            UsersList = new List<User>();
            AwardsList = new List<Award>();
        }

        static string connectionString = ConfigurationManager.AppSettings["connectionString"];
        private SqlConnection connection = new SqlConnection(connectionString);

        public static List<User> UsersList;
        public static List<Award> AwardsList;

        //add
        public void AddUser(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "InsertUser";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@firstName", SqlDbType.NVarChar));
                    command.Parameters.Add(new SqlParameter("@lastName", SqlDbType.NVarChar));
                    command.Parameters.Add(new SqlParameter("@birthDate", SqlDbType.DateTime2));

                    command.Prepare();

                    command.Parameters[0].Value = user.FirstName;
                    command.Parameters[1].Value = user.LastName;
                    command.Parameters[2].Value = user.BirthDate;

                    var result = command.ExecuteNonQuery();
                }
            }
        }
        public void AddUser(string fname, string lname, DateTime bdate, List<Award> awards)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                int newUserID;

                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "InsertUser";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@firstName", SqlDbType.NVarChar));
                    command.Parameters.Add(new SqlParameter("@lastName", SqlDbType.NVarChar));
                    command.Parameters.Add(new SqlParameter("@birthDate", SqlDbType.DateTime2));

                    command.Prepare();

                    command.Parameters[0].Value = fname;
                    command.Parameters[1].Value = lname;
                    command.Parameters[2].Value = bdate;

                    newUserID = Convert.ToInt32(command.ExecuteScalar());
                }
                foreach (Award award in awards)
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "InsertRelation";
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));
                        command.Parameters.Add(new SqlParameter("@awardID", SqlDbType.Int));

                        command.Parameters[0].Value = newUserID;
                        command.Parameters[1].Value = award.id;

                        var result = command.ExecuteNonQuery();
                    }
                }
            }
        }

        public void AddAward(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "InsertAward";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar));
                    command.Parameters.Add(new SqlParameter("@desciption", SqlDbType.NVarChar));

                    command.Prepare();

                    command.Parameters[0].Value = award.Title;
                    command.Parameters[1].Value = award.Description;

                    var result = command.ExecuteNonQuery();
                }
            }
        }
        public void AddAward(string title, string description)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "InsertAward";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar));
                    command.Parameters.Add(new SqlParameter("@description", SqlDbType.NVarChar));

                    command.Prepare();

                    command.Parameters[0].Value = title;
                    command.Parameters[1].Value = description;

                    var result = command.ExecuteNonQuery();
                }
            }
        }

        //update
        public void UpdateUser(User user, string fname, string lname, DateTime bdate, List<Award> awards)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "UpdateUser";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@firstName", SqlDbType.NVarChar));
                    command.Parameters.Add(new SqlParameter("@lastName", SqlDbType.NVarChar));
                    command.Parameters.Add(new SqlParameter("@birthDate", SqlDbType.DateTime2));

                    command.Prepare();

                    command.Parameters[0].Value = user.id;
                    command.Parameters[1].Value = fname;
                    command.Parameters[2].Value = lname;
                    command.Parameters[3].Value = bdate;

                    var result = command.ExecuteNonQuery();
                }
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "ClearUserRelations";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));

                    command.Prepare();

                    command.Parameters[0].Value = user.id;
                    var result = command.ExecuteNonQuery();
                }

                foreach (var award in awards)
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "UpdateRelation";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));
                        command.Parameters.Add(new SqlParameter("@awardID", SqlDbType.Int));

                        command.Prepare();

                        command.Parameters[0].Value = user.id;
                        command.Parameters[1].Value = award.id;

                        var result = command.ExecuteNonQuery();
                    }
                }
            }
        }
        public void UpdateAward(Award award, string title, string description)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "UpdateAward";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@awardID", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar));
                    command.Parameters.Add(new SqlParameter("@description", SqlDbType.NVarChar));

                    command.Prepare();

                    command.Parameters[0].Value = award.id;
                    command.Parameters[1].Value = title;
                    command.Parameters[2].Value = description;

                    var result = command.ExecuteNonQuery();
                }
            }
        }

        //remove
        public void RemoveUser(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "ClearUserRelations";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));

                    command.Prepare();

                    command.Parameters[0].Value = user.id;
                    var result = command.ExecuteNonQuery();
                }
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "RemoveUser";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));

                    command.Prepare();

                    command.Parameters[0].Value = user.id;

                    var result = command.ExecuteNonQuery();
                }
            }
        }
        public void RemoveUserById(int userId)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "RemoveUser";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));

                    command.Prepare();

                    command.Parameters[0].Value = userId;

                    var result = command.ExecuteNonQuery();
                }
            }
        }

        public void RemoveAward(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "RemoveAward";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@awardID", SqlDbType.Int));

                    command.Prepare();

                    command.Parameters[0].Value = award.id;

                    var result = command.ExecuteNonQuery();
                }
            }
        }
        public void RemoveAwardById(int awardId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "RemoveAward";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@awardID", SqlDbType.Int));

                    command.Prepare();

                    command.Parameters[0].Value = awardId;

                    var result = command.ExecuteNonQuery();
                }
            }
        }

        //get by id
        public Award GetAwardById(int awardId)
        {
            Award award = AwardsList.Find(a => a.id == awardId);
            return award;
        }
        public User GetUserById(int userId)
        {
            User user = UsersList.Find(u => u.id == userId);
            return user;
        }

        //getAll
        public List<User> GetAllUsers()
        {
            UsersList = new List<User>();

            using (var connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "GetAllUsers";
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var UserID = reader.GetInt32(0);
                            var FirstName = reader.GetString(1);
                            var LastName = reader.GetString(2);
                            var BirthDate = reader.GetDateTime(3);
                            var user = new User(UserID, FirstName, LastName, BirthDate, null); // NULL!!!!!!!!!!
                            UsersList.Add(user);

                        }
                    }

                    command.CommandText = "GetAllRelations";
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var UserID = reader.GetInt32(0);
                            var AwardID = reader.GetInt32(1);
                            GetUserById(UserID).Awards.Add(GetAwardById(AwardID));
                        }
                    }
                }
                return UsersList;
            }
        }

        public List<Award> GetAllAwards()
        {
            AwardsList = new List<Award>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "GetAllAwards";
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var AwardID = reader.GetInt32(0);
                            var Title = reader.GetString(1);
                            var Description = reader.GetString(2);
                            var award = new Award(AwardID, Title, Description);
                            AwardsList.Add(award);
                        }
                    }
                }
                return AwardsList;
            }
        }

        //convertToModels
        public List<UserViewModel> GetAllUserModels()
        {
            throw new Exception("Somethong gone wrong");
        }
    }
}
