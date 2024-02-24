using BDMaster.Models.DB;
using ResquestResponsModel;

namespace IBussniess
{
    public interface ITipoDocumentoBussnies
    {
        List<TipoDocumentoResponse> Getall();
        TipoDocumentoResponse GetById(int id);
        TipoDocumentoResponse Create(TipoDocumentoRequest entity);
        TipoDocumentoResponse Update(TipoDocumentoRequest entity);
        int Delete(object id);

    }
}
