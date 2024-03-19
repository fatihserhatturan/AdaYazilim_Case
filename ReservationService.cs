using AdaYazilim_Case.Models;

namespace AdaYazilim_Case
{
    public class ReservationService
    {

        private readonly DatabaseService _databaseService;

        public ReservationService(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public ReservationResponse MakeReservation(TrainReservationRequest request)
        {
            // Rezervasyon yapılabilir mi kontrol et
            bool isReservationPossible = IsReservationPossible(request);

            // Yanıt oluştur
            ReservationResponse response = new ReservationResponse();
            response.IsReservationPossible = isReservationPossible;
            response.PlacementDetails = isReservationPossible ? PlacePassengers(request) : new List<PlacementDetail>();

            return response;
        }

        private bool IsReservationPossible(TrainReservationRequest request)
        {
            // Tüm vagonlarda doluluk oranını kontrol et
            foreach (var vagon in request.Train.Wagons)
            {
                double dolulukOrani = (double)vagon.OccupiedSeatCount / vagon.Capacity;
                if (dolulukOrani >= 0.7)
                    return false;
            }

            return true;
        }

        private List<PlacementDetail> PlacePassengers(TrainReservationRequest request)
        {
            List<PlacementDetail> placementDetails = new List<PlacementDetail>();
            int remainingPersonCount = request.ReservationPersonCount;

            foreach (var vagon in request.Train.Wagons)
            {
                int availableSeats = vagon.Capacity - vagon.OccupiedSeatCount;
                if (availableSeats > 0 && (remainingPersonCount <= availableSeats || request.CanPeopleBePlacedInDifferentWagons))
                {
                    int personsToPlace = Math.Min(remainingPersonCount, availableSeats);
                    placementDetails.Add(new PlacementDetail { WagonName = vagon.Name, PersonCount = personsToPlace });
                    remainingPersonCount -= personsToPlace;
                }

                if (remainingPersonCount <= 0)
                    break;
            }

            return placementDetails;
        }
    }
}
