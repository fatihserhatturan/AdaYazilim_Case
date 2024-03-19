# AdaYazilim_Case

Bu proje, bir tren rezervasyonu uygulaması için geliştirilmiş bir HTTP API'ını içermektedir. API, istenilen rezervasyonun yapılıp yapılamayacağını ve yapılabiliyorsa hangi vagon için rezervasyonun onaylanabileceğini belirlemektedir.

## API Endpoint

API, `/Reservation` endpointi üzerinden POST isteklerine yanıt vermektedir.

## API Request Formatı

API'ye yapılan POST isteğinin formatı aşağıdaki gibidir:

```json
{
    "Tren": {
        "Ad": "Başkent Ekspres",
        "Vagonlar": [
            {"Ad": "Vagon 1", "Kapasite": 100, "DoluKoltukAdet": 68},
            {"Ad": "Vagon 2", "Kapasite": 90, "DoluKoltukAdet": 50},
            {"Ad": "Vagon 3", "Kapasite": 80, "DoluKoltukAdet": 80}
        ]
    },
    "RezervasyonYapilacakKisiSayisi": 3,
    "KisilerFarkliVagonlaraYerlestirilebilir": true
}
