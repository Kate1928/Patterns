﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIS_lab4_var6
{
    internal class Command
    {
        public Editor state; //Включение
        public FactoryAnimals.IDAnimals id;
        public string condition = "";
        public string Type = "";
        public string aviary = "";
        public string diet = "";
        public string therapy = "";
        
        public virtual void execute() { }
    }
    //concrete command
    internal class AddAnimal : Command
    {
        
        public AddAnimal(Editor en)
        {
            this.state = en;
        }
        

        public override void execute()
        {
            //AddForm3 addForm3 = (AddForm3)this.Owner;
            
            AddForm3 addForm3 = new AddForm3();
            addForm3.ShowDialog();
            condition = addForm3.condition3.Text;
            Type = addForm3.Type3.Text;
            aviary = addForm3.aviary3.Text;
            diet = addForm3.diet3.Text;
            therapy = addForm3.therapy3.Text;
            state.addAnimal(id, condition, Type, aviary, diet, therapy);//Делегирование
            addForm3.Close();
        }

    }

    internal class RemoveAnimal : Command
    {
        public RemoveAnimal(Editor en)
        {
            this.state = en;
        }
        public override void execute()
        {
            RemoveForm removeForm = new RemoveForm();
            removeForm.ShowDialog();
            int i = Int32.Parse(removeForm.IDtextManager.Text);
            state.removeAnimal(i);
            removeForm.Close();
        }

    }

    internal class Desinfection : Command
    {
        public Desinfection(Editor en)
        {
            this.state = en;
        }
        public override void execute()
        {
            DesClean des = new DesClean();
            des.ShowDialog();
            if(des.allBoxDes.Checked == true)
            {
                for(int i = 0; i < Aviary.aviarys.Count(); i++)
                {
                    state.desinfection(i);
                }                
            }
            if (des.OneBoxDes.Checked == true)
            {
                state.desinfection(Int32.Parse(des.IDBoxDes.Text));
            }
            des.Close();
        }
    }

    internal class Cleaning : Command
    {
        public Cleaning(Editor en)
        {
            this.state = en;
        }
        public override void execute()
        {
            DesClean des = new DesClean();
            des.ShowDialog();
            if (des.allBoxDes.Checked == true)
            {
                for (int i = 0; i < Aviary.aviarys.Count(); i++)
                {
                    state.cleaning(i);
                }
            }
            if (des.OneBoxDes.Checked == true)
            {
                state.cleaning(Int32.Parse(des.IDBoxDes.Text));
            }
            des.Close();
        }
    }
    internal class Feed : Command
    {
        public Feed(Editor en)
        {
            this.state = en;
        }
        public override void execute()
        {
            FeedForm feed = new FeedForm();
            feed.ShowDialog();
            if (feed.allBoxFeed.Checked == true)
            {
                for (int i = 0; i < FactoryAnimals.animals.Count(); i++)
                {
                    state.feeding(i);
                }
            }
            if (feed.oneBoxFeed.Checked == true)
            {
                state.feeding(Int32.Parse(feed.IDBoxFeed.Text));
            }
            feed.Close();

        }

    }
    internal class Treatment : Command
    {
        public Treatment(Editor en)
        {
            this.state = en;
        }
        public override void execute()
        {
            TreatmentForm treatment = new TreatmentForm();
            treatment.ShowDialog();
            if (treatment.therapyBox.Checked == true)
            {
                state.treatment(treatment.treatmentBox.Text, Int32.Parse(treatment.IDBoxThreatment.Text));
            }
            if (treatment.noTherapyBox.Checked == true)
            {
                state.treatment("отсутсвует", Int32.Parse(treatment.IDBoxThreatment.Text));
            }
            treatment.Close();
        }
    }

    internal class Cooling : Command
    {
        public Cooling(Editor en)
        {
            this.state = en;
        }
        public override void execute()
        {
            CoolHeatForm coolHeat = new CoolHeatForm();
            coolHeat.ShowDialog();
            //coolHeat.coolingBox.Visible = true;
            int i = Int32.Parse(coolHeat.IDBoxCoolHeat.Text);
            if (Aviary.aviarys[i].type == "закрытый")
            {
                state.cooling(i);
            }
            coolHeat.Close();
        }
    }

    internal class Heating : Command
    {
        public Heating(Editor en)
        {
            this.state = en;
        }
        public override void execute()
        {
            CoolHeatForm coolHeat = new CoolHeatForm();
            coolHeat.ShowDialog();
            //coolHeat.heatingBox.Visible = true;
            int i = Int32.Parse(coolHeat.IDBoxCoolHeat.Text);
            if (Aviary.aviarys[i].type == "закрытый")
            {
                state.heating(i);
            }
            coolHeat.Close();

        }
    }

    internal class ChangeState : Command
    {
        public ChangeState(Editor en)
        {
            this.state = en;
        }
        public override void execute()
        {
            ChangeForm changeForm = new ChangeForm();
            changeForm.ShowDialog();
            state.changeState(Int32.Parse(changeForm.IDBoxChange.Text), changeForm.stateBoxChange.Text);
        }
    }

    internal class Move : Command
    {
        public Move(Editor en)
        {
            this.state = en;
        }
        public override void execute()
        {
            MoveForm moveForm = new MoveForm();
            moveForm.ShowDialog();
            state.move(Int32.Parse(moveForm.IDBoxAnimal.Text), moveForm.IDBoxAviary.Text);
        }
    }
}
