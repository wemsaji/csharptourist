using digskill.tourapp;
using digskill.tourapp.abstracts;
using digskill.tourapp.touristspot;

Tourist tourist = new Tourist(50000);
tourist.TourStart();

TouristSpot artMuseum = new ArtMuseum();
tourist.Pay(artMuseum);
tourist.Visit(artMuseum);

TouristSpot worldHeritage = new WorldHeritage();
tourist.Pay(worldHeritage);
tourist.Visit(worldHeritage);

tourist.TourEnd();