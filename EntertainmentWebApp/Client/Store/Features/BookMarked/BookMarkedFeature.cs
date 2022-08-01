using EntertainmentWebApp.Client.Store.State;

namespace EntertainmentWebApp.Client.Store.Features.BookMarked;

public class BookMarkedFeature : Feature<BookMarkState>
{
    public override string GetName()
    {
        return "BookMarked";
    }

    protected override BookMarkState GetInitialState()
    {
        return new(false, null, null, null);
    }
}