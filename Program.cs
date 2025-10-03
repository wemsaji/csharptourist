using digskill.tourapp;
using digskill.tourapp.abstracts;
using digskill.tourapp.touristspot;
using digskill.tourapp.transportation;

Tourist tourist = new Tourist(50000);
tourist.TourStart();

TouristSpot artMuseum = new ArtMuseum();
tourist.Pay(artMuseum);
tourist.Visit(artMuseum);

TouristSpot worldHeritage = new WorldHeritage();
tourist.Pay(worldHeritage);
tourist.Visit(worldHeritage);

Transportation airplane = new Airplane(500);
tourist.Pay(airplane);
tourist.Ride(airplane);

Transportation train = new Train(100);
tourist.Pay(train);
tourist.Ride(train);

tourist.TourEnd();