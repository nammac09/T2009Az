using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.models
{
    class soundmanager
    {
        public static void GetAllSounds(ObservableCollection<sound> sounds)
        {
            var allSounds = GetSounds();
            sounds.Clear();
            allSounds.ForEach(a => sounds.Add(a));

        }
        public static void GetAllSoundsByName(ObservableCollection<sound> sounds, string name)
        {
            var allSounds = GetSounds();
            var filterSound = allSounds.Where(p => p.Name == name).ToList();
            sounds.Clear();
            filterSound.ForEach(a => sounds.Add(a));

        }
        public static List<sound> GetSounds()
        {
            var sounds = new List<sound>();
            sounds.Add(new sound("Ai là người thương em","AiLaNguoiThuongEmHtrolRemix-HtrolQuanAP-6008591.mp3", "188916860_2114570862016154_3530602907729272422_n.jpg"));
            sounds.Add(new sound("Bánh mì không","BanhMiKhongPhamThanhRemix-DatGDuUyen-6183898.mp3", "217725106_353519963096107_3605582024847334570_n.jpg"));
            sounds.Add(new sound("Bước qua đời nhau","BuocQuaDoiNhauTNBHRemix-LeBaoBinh-6060704.mp3", "219166246_353519666429470_3659797383302562334_n.jpg"));
            sounds.Add(new sound("Có chàng trai viết lên cây","CoChangTraiVietLenCayDJTranomRemix-PhanManhQuynh-6199143.mp3", "223476893_327703325504607_904176790025622997_n.jpg"));
            sounds.Add(new sound("Chân ái","ChanAiOrinnRemix-OrangeKhoiChauDangKhoa-6228503.mp3", "223789026_1194631127959862_1311795255548462586_n.jpg"));
            sounds.Add(new sound("Hai phút hơn","HaiPhutHonCM1XRemix-Phao-6216244.mp3", "225142196_278861777341673_757754177089051069_n.jpg"));

            return sounds;
        }
    }   
}
