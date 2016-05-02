using System.Collections.Generic;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace DesignPatterns.Data
{
    public class IconData
    {
        public List<string[]> IconRefGroups = new List<string[]>();
        public List<string> IconGroupTitles = new List<string>();
        public List<SolidColorBrush> IconGroupBrushes = new List<SolidColorBrush>();

        string[] HeartIconRefs = { "\uE006", "\uE0A5", "\uE007", "\uE00B", "\uE00C" };

        string[] StarIconRefs = { "\uE224", "\uE0B4", "\uE00A", "\uE082", "\uE0B5", "\uE7C6", "\uE7C7" };

        string[] CheckBoxIconRefs = { "\uE001", "\uE002", "\uE003", "\uE004", "\uE005", "\uE008", "\uE009",
                "\uE0A2", "\uE739", "\uE73A", "\uE73B", "\uE73C", "\uE73D", "\uE73E" };

        string[] MiscIconRefs = { "\uE134", "\uE113", "\uE195", "\uE734", "\uE735", "\uE8D9", "\uE19F",
                "\uE19E", "\uE19D", "\uE116", "\uE714", "\uE20B", "\uE248", "\uE249", "\uE24E", "\uE25A",
                "\uE25B", "\uE25C", "\uE25D", "\uE25E" };

        string[] ScrollArrowIconRefs = { "\uE00E", "\uE00F", "\uE010", "\uE011", "\uE016", "\uE017", "\uE018", "\uE019" };

        string[] BackButtonIconRefs = { "\uE0C4", "\uE0A6", "\uE0AD", "\uE0AB", "\uE830", "\uEA47", "\uE0D5", "\uE0AE" };

        string[] AppBarIconRefs = { "\uE8FB", "\uE910", "\uE710", "\uE8FA", "\uE7EF", "\uE8E3", "\uE8E4", "\uE8E2",
                "\uE71D", "\uE723", "\uE8A2", "\uE8D6", "\uE72B", "\uE73F", "\uE8F8", "\uE8DD", "\uE8A4", "\uE7C5",
                "\uE8FD", "\uE8EF", "\uE787", "\uE8BF", "\uE8F5", "\uE8C0", "\uE722", "\uE711", "\uE8BA", "\uE7F0",
                "\uE8EA", "\uE8C1", "\uE894", "\uE8E6", "\uE89F", "\uE753", "\uE90A", "\uE77B", "\uE8D4", "\uE779",
                "\uE8CF", "\uE8C8", "\uE7A8", "\uE8C6", "\uE74D", "\uE8F0", "\uE8D8", "\uE8CD", "\uE8E0", "\uE90E",
                "\uE90C", "\uE90D", "\uE8A5", "\uE896", "\uE70F", "\uE899", "\uE76E", "\uE728", "\uE734", "\uE735",
                "\uE71C", "\uE11A", "\uE7C1", "\uE8B7", "\uE8D2", "\uE8D3", "\uE8E7", "\uE8E8", "\uE8E9", "\uE72A",
                "\uE908", "\uE740", "\uE774", "\uE8AD", "\uE8FC", "\uE8D1", "\uE778", "\uE897", "\uE8C5", "\uE7E6",
                "\uE80F", "\uE8B5", "\uE8B6", "\uE8C9", "\uE8D8", "\uE765", "\uE89B", "\uE8F1", "\uE8E1", "\uE8DF",
                "\uE71B", "\uEA37", "\uE81D", "\uE715", "\uE8A8", "\uE89C", "\uE8CA", "\uE8C2", "\uE912", "\uE8CE",
                "\uE707", "\uE77C", "\uE8BD", "\uE720", "\uE712", "\uE8DE", "\uE90B", "\uE74F", "\uE8F4", "\uE78B",
                "\uE893", "\uE905", "\uE8E5", "\uE8DA", "\uE8A0", "\uE7AC", "\uE8B4", "\uE7EE", "\uE1CE", "\uE7C3",
                "\uE77F", "\uE769", "\uE716", "\uE8D7", "\uE717", "\uE780", "\uE718", "\uE768", "\uE8F3", "\uE8FF",
                "\uE8A1", "\uE892", "\uE8D0", "\uE8A6", "\uE8C3", "\uE7A6", "\uE72C", "\uE8AF", "\uE738", "\uE8AC",
                "\uE90F", "\uE8EE", "\uE8ED", "\uE730", "\uE8EB", "\uE7AD", "\uE89E", "\uE74E", "\uE78C", "\uE8FE",
                "\uE8B3", "\uE724", "\uE7B5", "\uE97B", "\uE713", "\uE72D", "\uE719", "\uE8C4", "\uE8BC", "\uE8B1",
                "\uE786", "\uE1CF", "\uE8CB", "\uE71A", "\uE913", "\uE8AB", "\uE8F9", "\uE895", "\uE8F7", "\uE8EC",
                "\uE907", "\uE7C9", "\uE78A", "\uE906", "\uE89A", "\uE8DC", "\uE7A7", "\uE8D9", "\uE77A", "\uE8F6",
                "\uE74A", "\uE898", "\uE8AA", "\uE890", "\uE8A9", "\uE767", "\uE8B8", "\uE909", "\uE904", "\uE71E",
                "\uE8A3", "\uE71F"};

        string[] BatteryIconRefs = { "\uE996", "\uE850", "\uE851", "\uE852", "\uE853", "\uE854", "\uE855", "\uE856",
            "\uE857", "\uE858", "\uE859", "\uE83F", "\uE85A", "\uE85B", "\uE85C", "\uE85D", "\uE85E", "\uE85F",
            "\uE860", "\uE861", "\uE862", "\uE83E", "\uEA93", "\uE863", "\uE864", "\uE865", "\uE866", "\uE867",
            "\uE868", "\uE869", "\uE86A", "\uE86B", "\uEA94", "\uEA95", "\uEC02", "\uEBA0", "\uEBA1", "\uEBA2",
            "\uEBA3", "\uEBA4", "\uEBA5", "\uEBA6", "\uEBA7", "\uEBA8", "\uEBA9", "\uEBAA", "\uEBAB", "\uEBAC",
            "\uEBAD", "\uEBAE", "\uEBAF", "\uEBB0", "\uEBB1", "\uEBB2", "\uEBB3", "\uEBB4", "\uEBB5", "\uEBB6",
            "\uEBB7", "\uEBB8", "\uEBB9", "\uEBBA", "\uEBBB", "\uEBBC", "\uEBBD", "\uEBBE", "\uEBBF", "\uEBC0" };

        public IconData()
        {
            IconRefGroups.Add(HeartIconRefs);
            IconGroupTitles.Add("Heart icons");
            IconGroupBrushes.Add(new SolidColorBrush(Colors.Red));

            IconRefGroups.Add(StarIconRefs);
            IconGroupTitles.Add("Star icons");
            IconGroupBrushes.Add(new SolidColorBrush(Colors.Yellow));

            IconRefGroups.Add(CheckBoxIconRefs);
            IconGroupTitles.Add("Check box icons");
            IconGroupBrushes.Add(new SolidColorBrush(Colors.Teal));

            IconRefGroups.Add(MiscIconRefs);
            IconGroupTitles.Add("Miscellaneous icons");
            IconGroupBrushes.Add(new SolidColorBrush(Colors.Aquamarine));

            IconRefGroups.Add(ScrollArrowIconRefs);
            IconGroupTitles.Add("Scroll arrow icons");
            IconGroupBrushes.Add(new SolidColorBrush(Colors.BlueViolet));

            IconRefGroups.Add(BackButtonIconRefs);
            IconGroupTitles.Add("Back button icons");
            IconGroupBrushes.Add(new SolidColorBrush(Colors.Crimson));

            IconRefGroups.Add(AppBarIconRefs);
            IconGroupTitles.Add("App bar icons");
            IconGroupBrushes.Add(new SolidColorBrush(Colors.DarkOliveGreen));

            IconRefGroups.Add(BatteryIconRefs);
            IconGroupTitles.Add("Battery icons");
            IconGroupBrushes.Add(new SolidColorBrush(Colors.Chocolate));
        }
    }
}
