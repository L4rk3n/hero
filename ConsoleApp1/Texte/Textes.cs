using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Texte
{
    public class Textes
    {
        public Dictionary<int, string> dictionnaire;

        public Textes()
        {
            dictionnaire = new Dictionary<int, string>
                {
                    { 0, "Bonjour aventurier bienvenue sur ascii-heroes! avant de démarrer l'aventure nous allons créer votre personnage" },
                    { 1, "Votre aventure commence dans une petite auberge à l'orée d'un bois dans la région de Kedétrave.\n Vous êtes venu ici cars vous avez entendu parler d'un dragon qui terrorise la région.\n Et qui dit dragon dit trésor\n Au petit matin vous décidez de prendre la route pour la ville de Grandbourg\n Cars les rumeurs viennent de là bas.\nVous pourriez passer par la forêt(2) ou suivre la grand route plus longue mais plus sûre(3)\n " },
                    { 2, "Vous vous engagez sur le chantier qui traverse la forêt, il ne faut pas longtemps pour que vous entendiez des bruits suspects dans les fourrés devant vous\nUne ombre apparait devant vous\n" },
                    { 3, "Vous suivez la route, le soleil brille  et une douce odeur de l'avande flotte dans l'air " },
                    { 4, "Vous arrivez devant la ville, que souhaitez vous faire aller acheter des potions de soins(5)\n vous rendre directement sur la place pour chercher des informations(6)? " },
                    { 5, "Vous arrivez devant la boutique du marchand de potion,\nune homme bizare en sort justement habillé d'une robe et d'un chapeau mauve fluorescent et une moustache en forme d'éclair.\n Vousle laisser passer avant d'entrer à votre tour" },
                    { 6, "Vous arrivez sur la place,il y a plusieurs personnes que vous pourriez interoger.\n il y a un marchand (7) qui vend des fruits et légumes,\nil y a le prêtre (8) qui nettoie le parvis de l'église\n et la laitière (9) à la fenêtre de son commerce entourée de ses fromages aux milles parfums. " },
                    { 7, "Vous discuter avec le marchand qui ne sait rien a propos d'un dragon, \net se plaint que le pont au nord est un véritable danger de mort vu son état.\nVous pouvez encore interoger le prêtre (8) et la laitière (9)" },
                    { 8, "Le prêtre plonger dans sa besogne est supris lorsque vous l'interpellez\n Il vous apprend qu'effectivement la tannière du dragon se trouve tout au sommet de la montagne au nord\n Et que pour vous rendre la bas il faut traverser la plaine d'Orbion qui sépare le village et le pied de la montagne.\nVous décidez de prendre la route(10)\n ou vous pouvez encore interoger le marchand (8) et la laitière (9) " },
                    { 9, "La laitière vous acceuille avec un grand sourrire,\n vous ne pouvez vous empêcher d'admirer la taille de ses poumons bien en évidence au milieu de ses produits.\nCependant hormis une agréable distraction visuelle,elle ne vous apprend rien d'interessant.\n Peut être que le prêtre(8) ou le marchand(7) pourrons enfin vous aider." },
                    { 10, "Vous sortez de la ville par la porte nord et vous admirrez devant vous l'étendue de la plaine d'Orbion verte et luxuriante.\nAu loingt vous voyez la montagne ou devrait se trouver le repaire du dragon.\n Mais pour cela il vous faudra traverser la plaine et affronter ces dangers.\n Vous suivez la route qui s'étend devant vous et qui semble mener tout droit vers votre destination.\n Après une demi journée de marche vous arrrivez devant un pont qui enjambe une très profonde crevasse.\nla route fait une fourche juste avant et vous avez le choix entre passer le pont(11)\n ou prendre l'autre embranchement (12)qui semble longer cette dite crevasse.\n" },
                    { 11, "Vous marcher le longt de la route qui semble longer la crevasse qui se prolonge a perte de vue.Celle-ci est bordée d'herbes hautes ou pourraient se cacher maintes ennemis.\n C'est donc tout en restant sur vos gardes que vous progresser." },
                    { 12, "Vous passer le pont sans encombre et vous continuez votre progression sur cette route, bordée d'herbes hautes ou pourraient se cacher maintes ennemis.\n C'est donc tout en restant sur vos gardes que vous progresser." },
                    { 13, "Apres de longues heures de marche, vous arrivez devant un pont qui est partiellement effondré, il est possible de le traverser mais cela à l'air dangereux." },
                    { 14, "les deux routes se rejoignent et le chemin continue tout droit jusque au pied de la montagne" },
                    { 15, "" },

                };
        }

    }
}
