﻿using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YeetPostV1_4.DataModel;
using YeetPostV1_4.ViewModel;

namespace YeetPostV1_4.Data
{
    public class CommentServices
    {
        private FirestoreDb db;


        public CommentServices()
        {


            GoogleCredential credential = GoogleCredential
               .FromFile(@"R:\YeetPost\YeetPost2\keys\yeetpost-firestore.json");
            ChannelCredentials channelCredentials = credential.ToChannelCredentials();
            Channel channel = new Channel(FirestoreClient.DefaultEndpoint.ToString(), channelCredentials);
            FirestoreClient firestoreClient = FirestoreClient.Create(channel);
            db = FirestoreDb.Create("yeetpost", client: firestoreClient);
        }



        //before we do this 
        // we need to check the DB
        public CommentViewModel getComment(string yeetID)
        {

            var comments = new CommentViewModel();

            Query query = db.Collection("Yeets").Document(yeetID).Collection("Comments");

            QuerySnapshot querySnapshot = query.GetSnapshotAsync().GetAwaiter().GetResult();

            if (querySnapshot.Documents.Count() == 0)
            {
                return comments;
            }


            List<Comments> come = new List<Comments>();

            foreach (DocumentSnapshot item in querySnapshot)
            {
                come.Add(new Comments
                {
                    dateadded = item.GetValue<DateTime>("dateadded").ToShortTimeString(),
                    comment = item.GetValue<string>("comment"),
                    Guid = item.GetValue<string>("Guid"),
                    username = item.GetValue<string>("username"),
                    commentID = item.Id,

                });
            }

            comments.yeet = getYeetAsync(yeetID);
            comments.comments = come;

            return comments;

        }

        public Yeet getYeetAsync(string yeetID)
        {

            var yeet = new Yeet();

            DocumentReference docRef = db.Collection("Yeets").Document(yeetID);
            DocumentSnapshot querySnapshot = docRef.GetSnapshotAsync().GetAwaiter().GetResult();
            
            
            if (querySnapshot.Exists)
            {
                yeet.date = querySnapshot.GetValue<DateTime>("date").ToShortTimeString();
                yeet.username = querySnapshot.GetValue<string>("username");
                yeet.Guid = querySnapshot.GetValue<string>("Guid");
                yeet.header = querySnapshot.GetValue<string>("header");
                yeet.totalLikes = querySnapshot.GetValue<string>("totalLikes");
                yeet.whoLikes = querySnapshot.GetValue<List<string>>("whoLikes");
                yeet.yeet = querySnapshot.GetValue<string>("yeet");
                yeet.location = querySnapshot.GetValue<string>("location");
                yeet.yeetID = querySnapshot.Id;
            }

            return yeet;

        }







    }
}
