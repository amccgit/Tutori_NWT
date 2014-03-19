using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    #region REST_Korisnik
    [OperationContract]
    [WebGet(ResponseFormat=WebMessageFormat.Json, UriTemplate="/korisnik/{idkorisnika}")]
    korisnik GetKorisnik(string idkorisnika);
    [OperationContract]
    [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,UriTemplate="/unesikorisnika")]
    void PostKorisnik(Stream streamdata);
    [OperationContract]
    [WebInvoke(Method="PUT",RequestFormat=WebMessageFormat.Json,UriTemplate="/izmjenikorisnika")]
    void PUTKorisnik(string streamdata);
    [OperationContract]
    [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, UriTemplate = "/obrisikorisnika")]
    void DeleteKorisnik(Stream streamdata);
    #endregion

    #region REST_Tutor
    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/tutor/{idtutora}")]
    tutor GetTutor(string idtutora);
    [OperationContract]
    [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, UriTemplate = "/unesitutora")]
    void PostTutor(Stream streamdata);
    [OperationContract]
    [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, UriTemplate = "/izmjenitutora")]
    void PUTTutor(string streamdata);
    [OperationContract]
    [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, UriTemplate = "/obrisitutor")]
    void DeleteTutor(Stream streamdata);
    #endregion

    #region REST_Kategorija
    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/kategorija/{idkategorija}")]
    kategorija GETKategorija(string idkategorija);
    [OperationContract]
    [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, UriTemplate = "/unesikategoriju")]
    void PostKategorija(Stream streamdata);
    [OperationContract]
    [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, UriTemplate = "/izmjenikategoriju")]
    void PUTKategorija(Stream streamdata);
    [OperationContract]
    [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, UriTemplate = "/obrisikategoriju")]
    void DELETEKategorija(Stream streamdata);
    #endregion

    #region REST_Komentar
    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/komentar/{idkomentara}")]
    komentar GETKomentar(string idkomentara);
    [OperationContract]
    [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, UriTemplate = "/unesikomentar")]
    void PostKomentar(Stream streamdata);
    [OperationContract]
    [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, UriTemplate = "/izmjenikomentar")]
    void PUTKomentar(Stream streamdata);
    [OperationContract]
    [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, UriTemplate = "/obrisikomentar")]
    void DELETEKomentar(Stream streamdata);
 #endregion

    #region REST_Oglas
    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/oglas/{idoglasa}")]
    oglas GETOglas(string idoglasa);
    [OperationContract]
    [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, UriTemplate = "/unesioglas")]
    void PostOglas(Stream streamdata);
    [OperationContract]
    [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, UriTemplate = "/izmjenioglas")]
    void PUTOglas(Stream streamdata);
    [OperationContract]
    [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, UriTemplate = "/obrisiOglas")]
    void DELETEOglas(Stream streamdata);
    #endregion

    #region REST_poruka
    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/poruka/{idporuka}")]
    poruka GETPoruku(string idporuka);
    [OperationContract]
    [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, UriTemplate = "/unesiporuku")]
    void PostPoruku(Stream streamdata);
    [OperationContract]
    [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, UriTemplate = "/izmjeniporuku")]
    void PUTPoruku(Stream streamdata);
    [OperationContract]
    [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, UriTemplate = "/obrisiporuku")]
    void DELETEPoruku(Stream streamdata);
    #endregion

    #region REST_Strucnost
    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/strucnost/{idstrucnost}")]
    strucnost GETStrucnost(string idstrucnost);
    [OperationContract]
    [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, UriTemplate = "/unesistrucnost")]
    void PostStrucnost(Stream streamdata);
    [OperationContract]
    [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, UriTemplate = "/izmjenistrucnost")]
    void PUTStrucnost(Stream streamdata);
    [OperationContract]
    [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, UriTemplate = "/obrisistrucnost")]
    void DELETEStrucnost(Stream streamdata);
    #endregion
}
