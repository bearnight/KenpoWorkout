using KenpoWorkout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KenpoWorkout.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                //YELLOW BELT TECHNIQUES
                new Item { Id = Guid.NewGuid().ToString(), Text = "DELAYED SHIELD 5.0", Description="(FRONT RIGHT HAND LAPEL GRAB)", BeltColor="YELLOW" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "ALTERNATING FIST 5.0", Description="FRONT TWO HAND PUSH", BeltColor="YELLOW" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "SHIELD OF DESTRUCTION 5.0", Description="(FRONT STEP THROUGH LEFT ROUNDHOUSE PUNCH)", BeltColor="YELLOW" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "DEFLECTING PENDULUM 5.0", Description="(FRONT RIGHT FRONT THRUST KICK)", BeltColor="YELLOW" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "CAPTURED TWIGS 5.0", Description="(REAR BEAR HUG WITH ARMS PINNED)", BeltColor="YELLOW" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "LONE KIMONO 5.0", Description="(FRONT LEFT HAND LAPEL GRAB)", BeltColor="YELLOW" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "OBSTRUCTING THE CLUB 5.0", Description="(FRONT RIGHT STP THROUGH OVERHEAD CLUB)", BeltColor="YELLOW" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "FIST OF AGGRESSION 5.0", Description="(FRONT TWO HAND LAPEL GRAB - PULLING IN)", BeltColor="YELLOW" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "ATTACKING FIST 5.0", Description="(FRONT RIGHT STEP THROUGH STRAIGHT PUNCH)", BeltColor="YELLOW" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "SWORD AND HAMMER 5.0", Description="(RIGHT FLANK LEFT HAND SHOULDER GRAB)", BeltColor="YELLOW" },
               //ORANGE BELT TECHNIQUES
                new Item { Id = Guid.NewGuid().ToString(), Text = "CLUTCHING FEATHERS 5.0", Description="(FRONT LEFT HAND, HAIR GRAB)", BeltColor="ORANGE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "TRIGGERED SALUTE 5.0", Description="FRONT RIGHT HAND DIRECT PUSH", BeltColor="ORANGE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "GLANCING SALUTE 5.0", Description="(FRONT RIGHT HAND CROSS PUSH)", BeltColor="ORANGE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "BUCKLING BRANCH 5.0", Description="(FRONT LEFT STEP THROUGH BALL KICK)", BeltColor="ORANGE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "CRASHING WINGS 5.0", Description="(REAR BEAR HUG ARMS FREE)", BeltColor="ORANGE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "GRIP OF THE SERPENT 5.0", Description="(LEFT FLANK RIGHT ARM HEADLOCK)", BeltColor="ORANGE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "OBSCURE WING 5.0", Description="(LEFT HAND SHOULDER GRAB FROM RIGHT FLANK)", BeltColor="ORANGE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "AGGRESSIVE TWINS 5.0", Description="(TWO HAND FRONT PUSH - RIGHT FOOT FORWARD", BeltColor="ORANGE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "REVERSING FIST 5.0", Description="(SHUFFLE LEFT JAB FROM LEFT FIGHTING STANCE)", BeltColor="ORANGE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "SHIELD AND HAMMER 5.0", Description="(SHUFFLE LEFT JAB FROM LEFT FIGHTING STANCE)", BeltColor="ORANGE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "FIVE SWORDS 5.0", Description="(SHUFFLE LEFT JAB, RIGHT CROSS COMBO FROM LEFT FIGHTING STANCE)", BeltColor="ORANGE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "RAINING CLAW 5.0", Description="(SHUFFLE LEFT JAB, RIGHT UPPERCUT COMBO FROM LEFT FIGHTING STANCE)", BeltColor="ORANGE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "GLANCING WING 5.0", Description="(SHUFFLE LEFT JAB, RIGHT CROSS, LEFT UPPERCUT TO MID-SECTION COMBO FROM LEFT FIGHTING STANCE)", BeltColor="ORANGE" },
               // PURPLE BELT TECHNIQUES
                new Item { Id = Guid.NewGuid().ToString(), Text = "TWIRLING WINGS 5.0", Description="(REAR STIFF TWO HAND NECK OR SHOULDER GRAB)", BeltColor="PURPLE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "LEAPING CRANE 5.0", Description="(FRONT RIGHT STEP THROUGH PUNCH)", BeltColor="PURPLE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "SWINGING PENDULUM 5.0", Description="(FRONT RIGHT STEP-THROUGH ROUNDHOUSE KICK FROM LEFT FIGHTING STANCE)", BeltColor="PURPLE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "STRIKING SERPENT'S HEAD 5.0", Description="(FRONT BEAR HUG ARMS FREE)", BeltColor="PURPLE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "EVADING THE CLUB 5.0", Description="(FRONT RIGHT STEP THROUGH OVERHEAD CLUB)", BeltColor="PURPLE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "CHECKING THE CLUB 5.0", Description="(FRONT RIGHT STEP THROUGH OVERHEAD CLUB)", BeltColor="PURPLE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "CROSSING TALON 5.0", Description="(FRONT RIGHT CROSS WRIST GRAB)", BeltColor="PURPLE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "CHARGING MACE 5.0", Description="(OFFENSIVE COMBINATION FROM A LEFT FIGHTING STANCE)", BeltColor="PURPLE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "HAMMERING MACE 5.0", Description="(OFFENSIVE COMBINATION FROM A LEFT FIGHTING STANCE)", BeltColor="PURPLE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "RETURNING MACE 5.0", Description="(OFFENSIVE COMBINATION FROM A LEFT FIGHTING STANCE)", BeltColor="PURPLE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "HOOKING WINGS 5.0", Description="(FRONT ATTEMPTED BODY LOCK TAKEDOWN)", BeltColor="PURPLE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "THRUSTING KNEE 5.0", Description="(FRONT ATTEMPTED BODY LOCK TAKEDOWN)", BeltColor="PURPLE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "OPPOSING CIRCLES 5.0", Description="(FRONT BODY LOCK ARMS FREE - HEAD RIGHT OF CENTER)", BeltColor="PURPLE" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "COLLAPSING WEDGE 5.0", Description="(FRONT BODY LOCK ARMS FREE - HEAD LEFT OF CENTER)", BeltColor="PURPLE" }

            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}