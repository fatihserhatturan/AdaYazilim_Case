using AdaYazilim_Case.Models;

namespace AdaYazilim_Case
{
    public class ReservationService
    {
        public ReservationResponse MakeReservation(ReservationRequest request)
        {
            if (request == null || request.Tren == null || request.Tren.Vagonlar == null || request.Tren.Vagonlar.Count == 0)
            {
                return new ReservationResponse { RezervasyonYapilabilir = false, YerlesimAyrinti = new List<ReservationDetail>() };
            }

            List<ReservationDetail> yerlesimAyrinti = new List<ReservationDetail>();

            int kalanKisiSayisi = request.RezervasyonYapilacakKisiSayisi;
            foreach (var vagon in request.Tren.Vagonlar.OrderBy(v => v.DoluKoltukAdet))
            {
                if (kalanKisiSayisi == 0)
                {
                    break; 
                }

                int bosKoltukSayisi = vagon.Kapasite - vagon.DoluKoltukAdet;
                if (bosKoltukSayisi > 0 && (double)vagon.DoluKoltukAdet / vagon.Kapasite < 0.7)
                {
                    int kisiSayisiBuVagonaYerlestirilecek = kalanKisiSayisi > bosKoltukSayisi ? bosKoltukSayisi : kalanKisiSayisi;
                    yerlesimAyrinti.Add(new ReservationDetail { VagonAdi = vagon.Ad, KisiSayisi = kisiSayisiBuVagonaYerlestirilecek });
                    kalanKisiSayisi -= kisiSayisiBuVagonaYerlestirilecek;
                }
            }

            return new ReservationResponse
            {
                RezervasyonYapilabilir = kalanKisiSayisi == 0,
                YerlesimAyrinti = yerlesimAyrinti
            };
        }
    }
}
