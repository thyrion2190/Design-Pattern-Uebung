using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternExample
{
    public class FacadeLuggageManagement
    {
        private AirportSystem airport;
        private AirplaneSystem airplane;
        private LocalTransportSystem localTransportSystem;
        private Hotel hotel;

        public FacadeLuggageManagement()
        {
            airport = new AirportSystem();
            airplane = new AirplaneSystem();
            localTransportSystem = new LocalTransportSystem();
            hotel = new Hotel();
        }

        public void SendLuggage()
        {
            airport.CheckLuggage();
            airport.TransportLuggageToAirplane();
            airplane.LoadingTheLuggage();
            airplane.UnloadingTheLuggage();
            localTransportSystem.LoadingLuggageInTruck();
            localTransportSystem.TransportLuggageToHotel();
            hotel.TransportLuggageToRoom();
        }
    }
}
