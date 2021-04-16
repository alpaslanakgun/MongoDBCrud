using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AdressBook");


            //PersonModel person = new PersonModel
            //{
            //    FirstName = "Alpaslan",
            //    LastName = "Akgun",
            //    PrimaryAdress = new AdressModel
            //    {
            //        StreetAdress = "101 Street",
            //        City = "İstanbul",
            //        State = "PA",
            //        ZipCode = "34219"
            //    }
            //};


            //db.InsertRecord("Users", person);


            //var recs = db.LoadRecords<PersonModel>("Users");
            //foreach (var item in recs)
            //{
            //    Console.WriteLine($"{item.Id}:{item.FirstName}:{item.LastName}");
            //    if (item.PrimaryAdress!=null)
            //    {
            //        Console.WriteLine(item.PrimaryAdress.City);
            //    }
            //    Console.WriteLine();
            //}

            var oneRec=db.LoadRecordById<PersonModel>("Users",new Guid("9da3a596-d41a-4f78-97fe-71a2c23e7523"));

            //oneRec.DateOfBirth = new DateTime(1991, 11, 09, 0, 0, 0,DateTimeKind.Utc);
            //db.UpsertRecord("Users", oneRec.Id, oneRec);


            db.DeleteRecord<PersonModel>("Users", oneRec.Id);

            Console.ReadLine();
        }
    }
}
