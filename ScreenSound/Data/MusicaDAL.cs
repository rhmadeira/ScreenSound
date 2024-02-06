using ScreenSound.Modelos;

namespace ScreenSound.Data;

internal class MusicaDAL : DAL<Musica>
{

    public MusicaDAL(ScreenSoundContext context): base(context) {}

}
