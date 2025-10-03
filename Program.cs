using digskill.tourapp;
using digskill.tourapp.touristspot;

Tourist tourist = new Tourist(50000);
tourist.TourStart();

ArtMuseum artMuseum = new ArtMuseum();
tourist.Pay(artMuseum);
tourist.Visit(artMuseum);

tourist.TourEnd();