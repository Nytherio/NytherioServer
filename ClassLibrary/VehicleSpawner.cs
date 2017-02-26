using System;
using GTANetworkServer;
using GTANetworkShared;

namespace TestServer
{
    public class VehicleSpawner : Script

    {
        [Command("vehicle")]
        public void VehicleSpawn(Client sender, VehicleHash vehicle)
        {
             Vehicle spawnedVehicle = API.createVehicle(vehicle, sender.position, sender.rotation, 0, 0);
            API.setPlayerIntoVehicle(sender, spawnedVehicle, -1);
            API.setVehicleEngineStatus(spawnedVehicle, true);
        }
    }
}