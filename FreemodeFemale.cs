using GTA;
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;
using GTA.NaturalMotion;
using GTA.Native;
using GTA.Math;

public class ChangePlrModel : Script
{
    Keys changeModelKey = Keys.F10;

    public ChangePlrModel()

    {
        KeyDown += ChangePlrModel_KeyDown;
    }

    private void ChangePlrModel_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F10)
        {
            var characterModel = new Model(PedHash.FreemodeFemale01);
            characterModel.Request(500);

        if (characterModel.IsInCdImage && characterModel.IsValid)
            {

                while (!characterModel.IsLoaded) Script.Wait(100);
                
                UI.Notify("~y~Freemode Player Loaded..");
                
                Function.Call(Hash.SET_PLAYER_MODEL, Game.Player, characterModel.Hash);
                
                Function.Call(Hash.SET_PED_COMPONENT_VARIATION, Game.Player.Character.Handle, 0, 0, 0); // Head
                Function.Call(Hash.SET_PED_COMPONENT_VARIATION, Game.Player.Character.Handle, 1, 0, 0); // Mask
                Function.Call(Hash.SET_PED_COMPONENT_VARIATION, Game.Player.Character.Handle, 2, 42, 0); // Hair
                Function.Call(Hash.SET_PED_COMPONENT_VARIATION, Game.Player.Character.Handle, 3, 70, 0); // Torso and Gloves
                Function.Call(Hash.SET_PED_COMPONENT_VARIATION, Game.Player.Character.Handle, 4, 73, 0); // Pants legs
                Function.Call(Hash.SET_PED_COMPONENT_VARIATION, Game.Player.Character.Handle, 5, 0, 0); // Parachute and Hands
                Function.Call(Hash.SET_PED_COMPONENT_VARIATION, Game.Player.Character.Handle, 6, 77, 4); // Shoes
                Function.Call(Hash.SET_PED_COMPONENT_VARIATION, Game.Player.Character.Handle, 7, 0, 0); // Accessories
                Function.Call(Hash.SET_PED_COMPONENT_VARIATION, Game.Player.Character.Handle, 8, 2, 0); // Tops iner
                Function.Call(Hash.SET_PED_COMPONENT_VARIATION, Game.Player.Character.Handle, 9, 0, 0); // BodyArmor
                Function.Call(Hash.SET_PED_COMPONENT_VARIATION, Game.Player.Character.Handle, 10, 0, 0); // CrewEmblem
                Function.Call(Hash.SET_PED_COMPONENT_VARIATION, Game.Player.Character.Handle, 11, 49, 1); // Tops outer

                Function.Call(Hash.SET_PED_HEAD_BLEND_DATA, Game.Player.Character.Handle, 31, 0, 0, 0, 0);

                Function.Call(Hash._SET_PED_HAIR_COLOR, Game.Player.Character, 0);
                Function.Call(Hash._SET_PED_EYE_COLOR, Game.Player.Character.Handle, 3);

                Function.Call(Hash.SET_RUN_SPRINT_MULTIPLIER_FOR_PLAYER, Game.Player.Handle, 1.49f);
                Function.Call(Hash.SET_SWIM_MULTIPLIER_FOR_PLAYER, Game.Player.Handle, 1.49f);

                Function.Call(Hash.SET_PLAYER_MELEE_WEAPON_DAMAGE_MODIFIER, Game.Player, 0.72f);
                Function.Call(Hash.SET_PLAYER_MELEE_WEAPON_DEFENSE_MODIFIER, Game.Player, 0.72f);

                Function.Call(Hash.SET_PLAYER_WEAPON_DAMAGE_MODIFIER, Game.Player, 0.72f);
                Function.Call(Hash.SET_PLAYER_WEAPON_DEFENSE_MODIFIER, Game.Player, 0.72f);            
                                       
                Function.Call(Hash.ADD_ARMOUR_TO_PED, Game.Player.Character, 100, true);
                Function.Call(Hash.CLEAR_PLAYER_WANTED_LEVEL, Game.Player);
		
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x9D1F17E6, 1000); // Military Rifle
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xBFE256D4, 1000); // Pistol MkII
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x22D8FE39, 1000); // APPistol
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x917F6C8C, 1000); // NavyRevolver
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x7F229F94, 1000); // BullpupRifle
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xBFEFFF6D, 1000); // AssaultRifle
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xE284C527, 1000); // AssaultShotgun
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xA914799, 1000); // Heavy Sniper Mk2
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x476BF155, 1000); // Unholy Hellbringer
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xAF3696A1, 1000); // Up-n-Atomizer
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xFAD1F1C9, 1000); // Carbine Rifle Mk2
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x61012683, 1000); // Gusenberg Sweeper 
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xBA45E8B8, 1000); // Pipe Bombs
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x3656C8C1, 1000); // StunGun
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xA284510B, 1000); // GrenadeLauncher
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xB62D1F67, 1000); // Widowmaker
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x42BF8A85, 1000); // Minigun
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x93E220BD, 1000); // Grenade
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 741814745, 1000);  // StickyBomb
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x24B17070, 1000); // Molotov
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x34A67B97, 1000); // PetrolCan
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xC0A3098D, 1000); // SpecialCarbine
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 3686625920, 1000); // CombatMG Mk2
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x63AB0442, 1000); // HomingLauncher
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xAB564B93, 1000); // ProximityMine
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x787F0BB, 1000);  // Snowball
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x7F7497E5, 1000); // Firework
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xC734385A, 1000); // MarksmanRifle
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x6D544C99, 1000); // Railgun
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, -538741184); // SwitchBlade
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, -1951375401); // Flashlight
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x3813FC08); // Stone Hatchet
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xD8DF3C3C); // Brass Knuckles
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0x19044EE0); // Pipe Wrench
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xDD5DF8D9); // Machete
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, -2067956739); // Crowbar
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xA2719263); // Unarmed
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, 0xB1CA77B1, 1000); // RPG
                Function.Call(Hash.GIVE_WEAPON_TO_PED, Game.Player.Character, -1786099057); // Bat
                
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.CarbineRifleMk2), 3);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.AssaultRifle), 0);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.AssaultShotgun), 7);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.SpecialCarbine), 7);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.BullpupRifle), 7);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.MarksmanRifle), 0);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.APPistol), 5);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.PistolMk2), 17);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.Gusenberg), 7);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.CombatMGMk2), 20);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.HeavySniperMk2), 20);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.HomingLauncher), 7);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.GrenadeLauncher), 7);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.Railgun), 0);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.Minigun), 7);
                Function.Call(Hash.SET_PED_WEAPON_TINT_INDEX, Game.Player.Character, unchecked((int)WeaponHash.RPG), 7);

                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character.Handle, unchecked((int)WeaponHash.CombatMGMk2), 0x17DF42E9);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character.Handle, unchecked((int)WeaponHash.CombatMGMk2), 0x9D65907A);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character.Handle, unchecked((int)WeaponHash.CombatMGMk2), 0xC66B6542);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character.Handle, unchecked((int)WeaponHash.CombatMGMk2), 0xDE11CBCF);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character.Handle, unchecked((int)WeaponHash.CombatMGMk2), 0xB5E2575B);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.CarbineRifleMk2), 0x4C7A391E);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.CarbineRifleMk2), 0x9D65907A);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.CarbineRifleMk2), 0xC66B6542);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.CarbineRifleMk2), 0xEC9068CC);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.CarbineRifleMk2), 0x8B3C480B);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.CarbineRifleMk2), 0x837445AA);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character.Handle, (int) WeaponHash.BullpupRifle, 0x837445AA);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character.Handle, (int) WeaponHash.BullpupRifle, 0xB3688B0F);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character.Handle, (int) WeaponHash.BullpupRifle, 0xAA2C45B4);

                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.SpecialCarbine), 0x7C8BD10E);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.SpecialCarbine), 0x7BC4CDDC);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.SpecialCarbine), 0xA0D89C42);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.SpecialCarbine), 0xC164F53);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.SpecialCarbine), 0x730154F2);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.PistolMk2), 0x94F42D62);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.PistolMk2), 0x697E19A0);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.Gusenberg), 0xEAC8C270);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.MarksmanRifle), 0xD83B4141);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.MarksmanRifle), 0x1C221B1A);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.MarksmanRifle), 0xC164F53);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.HeavySniperMk2), 0x2CD8FF9D);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.HeavySniperMk2), 0x2E43DA41);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.HeavySniperMk2), 0x6927E1A1);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.HeavySniperMk2), 0x108AB09E);
                
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.AssaultRifle), 0xB1214F9B);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.AssaultRifle), 0xC164F53);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.AssaultShotgun), 0x86BD7F72);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.AssaultShotgun), 0x837445AA);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.AssaultShotgun), 0xC164F53);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.AssaultShotgun), 0x7BC4CDDC);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.GrenadeLauncher), 0x11AE5C97);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.GrenadeLauncher), 0x7BC4CDDC);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.GrenadeLauncher), 0xC164F53);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.GrenadeLauncher), 0xAA2C45B4);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.KnuckleDuster), 0xE28BABEF);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, unchecked((int)WeaponHash.SwitchBlade), 0x5B3E7DB6);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, (int) WeaponHash.APPistol, 0xC304849A);
                Function.Call(Hash.GIVE_WEAPON_COMPONENT_TO_PED, Game.Player.Character, (int) WeaponHash.APPistol, 0x249A17D5);

                Function.Call(Hash.SET_CURRENT_PED_WEAPON, Game.Player.Character, (uint)WeaponHash.Unarmed, true);
                Function.Call(Hash.SET_PED_INFINITE_AMMO_CLIP, Game.Player.Character, true);

                Game.Globals[4].SetInt(1);Function.Call(Hash.TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME, "respawn_controller");

                Function.Call(Hash.ENABLE_ALL_CONTROL_ACTIONS, Game.Player.Character, 1);
                Function.Call(Hash.DISABLE_HOSPITAL_RESTART, Game.Player.Character, 1);
                Function.Call(Hash.SET_FADE_OUT_AFTER_DEATH, Game.Player.Character, 0);
                Function.Call(Hash.IGNORE_NEXT_RESTART, Game.Player.Character, 1);

}

            characterModel.MarkAsNoLongerNeeded();
	
 }
    }
 }                  