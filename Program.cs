using digskill.tourapp;
using digskill.tourapp.abstracts;
using digskill.tourapp.restaurant;
using digskill.tourapp.touristspot;
using digskill.tourapp.transportation;

Tourist tourist = new Tourist(50000);
tourist.TourStart();

Transportation airplane = new Airplane(500);
tourist.Pay(airplane);
tourist.Ride(airplane);

Restaurant cafe = new Cafe("パスタ");
tourist.Pay(cafe);
tourist.Eat(cafe);

TouristSpot artMuseum = new ArtMuseum();
tourist.Pay(artMuseum);
tourist.Visit(artMuseum);

Transportation train = new Train(100);
tourist.Pay(train);
tourist.Ride(train);

TouristSpot worldHeritage = new WorldHeritage();
tourist.Pay(worldHeritage);
tourist.Visit(worldHeritage);

Restaurant french = new French("ステーキ");
tourist.Pay(french);
tourist.Eat(french);

tourist.TourEnd();