using IntroToMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IntroToMVVM.ViewModels
{
    class YGOMonsterViewModel
    {
        public ObservableCollection<YGOMonster> YGOMonsters { get; set; }
        public YGOMonsterViewModel()
        {
            YGOMonsters = new ObservableCollection<YGOMonster>
            {
                new YGOMonster("Dark Magician",7,"Dark",2500,2100,"Spellcaster",false,"The ultimate wizard in terms of attack and defense.","https://i1.sndcdn.com/avatars-000333630611-enn4zu-t500x500.jpg"),
                new YGOMonster("Blue-Eyes White Dragon",8,"Light",3000,2500,"Dragon",false,"This legendary dragon is a powerful engine of destruction. Virtually invincible, very few have faced this awesome creature and lived to tell the tale.","https://i.pinimg.com/originals/cd/ed/20/cded20a34649a84f912d5ade33585714.jpg"),
                new YGOMonster("Summoned Skull",6,"Dark",2500,1200,"Fiend",false,"A fiend with dark powers for confusing the enemy. Among the Fiend-Type monsters, this monster boasts considerable force.","https://uploads3.yugioh.com/card_images/293/detail/Summoned-Skull.jpg?1375128467"),
                new YGOMonster("Samson",2,"Earth",100,100,"Beast",false,"Dag meneer Spaghetti!","https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQN71SXQt4EnfNko1Iuootk-uVL0qIBx9RmG1iCHFGnpe2WQceDwDNbf6irp9LFKPSp0E0&usqp=CAU"),
                new YGOMonster("Albert Vermeersch",4,"Fire",1500,1000,"Kapper",false,"'Tis Al-ber-TO!","https://www.thebestsocial.media/wp-content/uploads/sites/2/2018/01/Schermafbeelding-2018-01-04-om-11.15.19-1024x697.png"),
            };
        }
    }
}
