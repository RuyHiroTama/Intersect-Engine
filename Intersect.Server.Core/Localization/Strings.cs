using System.Text;
using Intersect.Config;
using Intersect.Localization;
using Intersect.Logging;
using Intersect.Server.Core;
using Intersect.Server.Networking.Helpers;
using Newtonsoft.Json;

namespace Intersect.Server.Localization;


public static partial class Strings
{

    public sealed partial class AccountNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString AccountAlreadyExists = @"Account already exists!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString AccountDoesNotExist = @"Account does not exist.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString AdminOnly = @"The server is currently allowing only admins to connect. Please come back later!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString AlreadyBanned = @"{00} has already been banned!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString AlreadyMuted = @"{00} has already been muted!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString BadAccess = @"Access denied! Invalid power level!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString BadLogin = @"Username or password incorrect.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString BanStatus = @"Your account has been banned since: {00} (UTC) by {01}. Ban expires: {02} (UTC). Reason for ban: {03}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Banned = @"{00} has been banned!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString CharacterExists = @"An account with this character name already exists. Please choose another.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString CharacterDeleted = @"The character has been deleted.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString DeleteCharacterError = @"This character cannot be deleted, they may be stuck online in combat.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString EmailExists = @"An account with this email address already exists.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString EmailFail = @"Failed to send your password reset email at this time. Please try again later.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InvalidClass = @"Invalid class selected. Please try again.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InvalidEmail = @"The chosen email does not meet the requirements set by the server.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InvalidName = @"The chosen name does not meet the requirements set by the server.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString LoadFail = @"Failed to load account. Please try logging in again.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString MaxCharacters = @"You have already created the maximum number of characters. Delete one before creating a new one.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Muted = @"{00} has been muted!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString MuteStatus = @"Your account has been muted since: {00} by {01}. Mute expires: {02}. Reason for mute: {03}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NotAllowed = @"You do not have the permission to do this.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NotFound = @"Error: Account {00} was not found!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString RegistrationsBlocked = @"Account registrations are currently blocked by the server.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString UnbanFail = @"Failed to unban {00}. The user is not banned!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString UnbanSuccess = @"{00} has been unbanned!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString UnknownError = @"An unknown error occurred while saving the user.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString UnmuteFail = @"Failed to unmute {00}. The user is not muted!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString UnmuteSuccess = @"{00} has been unmuted!";
    }

    public sealed partial class BagNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString BagInBag = @"You cannot store a bag inside another bag!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString BagInSelf = @"You cannot store a bag within itself!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString BagNoSpace = @"There is no space left in your bag for that item!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString DropNotEmpty = @"You cannot drop a bag unless it's empty!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString OnlySellEmpty = @"Cannot sell the bag unless it's empty!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString OnlyTradeEmpty = @"Cannot trade the bag unless it's empty!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString SlotOccupied = @"That slot is occupied by another item!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString TradeBound = @"Cannot trade bound items!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString WithdrawInvalid = @"Invalid item selected to retrieve!";
    }

    public sealed partial class BankNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString BankNoSpace = @"There is no space left in your bank for that item!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString DepositInvalid = @"Invalid item selected to deposit!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString DepositSuccessNonStackable = @"You have stored: {00}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString DepositSuccessStackable = @"You have stored: {00} {01}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InvalidSlotToSwap = @"Invalid slots to swap!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InventoryNoSpace = @"There is no space left in your inventory for that item!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString WithdrawInvalid = @"Invalid item selected to withdraw!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString WithdrawSuccessNonStackable = @"You have withdrawn: {00}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString WithdrawSuccessStackable = @"You have withdrawn: {00} {01}";
    }

    public sealed partial class ChatNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Admin = @"[ADMIN] {00}: {01}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString AdminCommand = @"/admin";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString AllCommand = @"/all";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Announcement = @"[ANNOUNCEMENT] {00}: {01}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString AnnouncementCommand = @"/announcement";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Global = @"[GLOBAL] {00}: {01}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString GlobalCommand = @"/global";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Local = @"{00}: {01}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString LocalCommand = @"/local";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString MessageCommand = @"/message";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Party = @"[PARTY] {00}: {01}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PartyCommand = @"/party";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PrivateFrom = @"[PM] From {00}: {01}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PrivateTo = @"[PM] To {00}: {01}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PrivateMessageCommand = @"/pm";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ReplyCommand = @"/reply";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ReplyShortcutCommand = @"/r";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString TooFast = @"You are chatting too fast!";
    }

    public sealed partial class ClassNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString LastClass = @"Last Class";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString LastClassError = @"Failed to delete class. You must have at least one class at all times!";
    }

    public sealed partial class ColorNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocaleDictionary<int, LocalizedString> Presets =
        new LocaleDictionary<int, LocalizedString>(new Dictionary<int, LocalizedString>
            {
                {0, @"Black"},
                {1, @"White"},
                {2, @"Pink"},
                {3, @"Blue"},
                {4, @"Red"},
                {5, @"Green"},
                {6, @"Yellow"},
                {7, @"Orange"},
                {8, @"Purple"},
                {9, @"Gray"},
                {10, @"Cyan"}
            }
        );
    }

    public sealed partial class CombatNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString AddSymbol = @"+";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Blocked = @"BLOCKED!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Channeling = @"You are currently channeling another skill.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ChannelingNoAttack = @"You are currently channeling a spell, you cannot attack.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Cooldown = @"This skill is on cooldown.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Critical = @"CRITICAL HIT!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Dash = @"DASH!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString DynamicRequirement = @"You do not meet the requirements to cast the spell!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ImmuneToEffect = @"IMMUNE!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString LevelUp = @"LEVEL UP!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString LowHealth = @"Not enough health.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString LowMana = @"Not enough mana.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Miss = @"MISS!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString RemoveSymbol = @"-";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ResourceRequirements = @"You do not meet the requirements to harvest this resource!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Silenced = @"You cannot cast this ability while silenced.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Sleep = @"You cannot cast this ability while asleep.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Snared = @"You cannot cast this ability while snared.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString SleepAttacking = @"You are asleep and can't attack.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString SleepBlocking = @"You are asleep and can't block.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocaleDictionary<int, LocalizedString> Status = new LocaleDictionary<int, LocalizedString>(
            new Dictionary<int, LocalizedString>
            {
            {0, @"NONE!"},
            {1, @"SILENCED!"},
            {2, @"STUNNED!"},
            {3, @"SNARED!"},
            {4, @"BLINDED!"},
            {5, @"STEALTH!"},
            {6, @"TRANSFORMED!"},
            {7, @"CLEANSED!"},
            {8, @"INVULNERABLE!"},
            {9, @"SHIELD!"},
            {10, @"SLEEP!"},
            {11, @"ON HIT!"},
            {12, @"TAUNT!"},
            }
        );

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString StunAttacking = @"You are stunned and can't attack.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString StunBlocking = @"You are stunned and can't block.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Stunned = @"You cannot cast this ability while stunned.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString TargetOutOfRange = @"Target is out of range!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ToolRequired = @"You require a {00} to interact with this resource!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString TryForgetBoundSpell = @"You cannot forget this spell.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InvalidTarget = @"Invalid target for this spell.";
    }

    public sealed partial class CommandOutputNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString AccountCount = @" - {00} Accounts.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ActiveConnections = @"Active connections: {00}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ApiAccessGranted = @"{00} now has API access!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ApiAccessRevoked = @"{00} has had their API access revoked!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ApiRoleGranted = @"{00} now has the {01} API role!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ApiRoleNotFound = @"API role {00} not found!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ApiRoleNotGranted = @"Failed to assign API role {00}, API access must be enabled for {01} first!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ApiRolePrerequisite = @"API role {00} could not be granted! Depends on {01} role.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ApiRoleRevoked = @"{00} has had their {01} API role revoked!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ApiRoles = @"API roles for {00}:";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString CharacterCount = @" - {00} Characters.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString CpsLocked = @"CPS Locked";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString CpsUnlocked = @"CPS Unlocked";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString EventCount = @" - {00} Events.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ExperimentalFeatureEnablement = @"{00} is {01}.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString GameTime = @"Game time is now: {00}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString HelpFooter = @"Type in any command followed by {00} for parameters and usage information.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString HelpHeader = @"List of available commands:";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ItemCount = @" - {00} Items.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString KillSuccess = @"{00} has been killed!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ListAccount = @"Account";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ListCharacter = @"Character";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ListId = @"ID";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString MapCount = @" - {00} Maps.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString MetricsDisabled = @"Metrics collection disabled";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString MetricsEnabled = @"Metrics collection enabled";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NoClientsConnected = @"No clients connected";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NpcCount = @" - {00} NPCs.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PowerChanged = @"{00} has had their power updated!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ServerInfo = @"Server has:";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString SpellCount = @" - {00} Spells.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString StrayConnections = @"Stray connections: {00}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString VariableChanged = @"'{01}' set to {02} (was {03}) ({00})";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString VariableListEmpty = @"There are no variables to display.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString VariableNotFound = @"Variable '{00}' not found";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString VariablePrint = @"{00} {01} = {02}";
    }

    public sealed partial class CraftingNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString AlreadyCrafting = @"You are already crafting an item!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString CraftFailure = @"The attempt to craft the item {00} failed!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString CraftFailureLostItems = @"The attempt to craft the item {00} failed, and you lost the materials!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Crafted = @"You have successfully crafted {00}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InJournalMode = @"You cannot craft items from your crafting journal!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NoSpace = @"You do not have enough inventory space to craft {00}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString RequirementsNotMet = @"You do not meet the requirements to craft this item!";
    }

    public sealed partial class DatabaseNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocaleDictionary<DatabaseType, LocalizedString> DatabaseTypes = new(
            new Dictionary<DatabaseType, LocalizedString>
            {
            { DatabaseType.Sqlite, "SQLite" },
            { DatabaseType.MySql, "MySql" }
            }
        );

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Default = @"Default";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString MigratingAutomatically = @"The --migrate-automatically flag was passed to the server on startup, so the user will not be prompted.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NoClasses = @"No classes found! Creating a default class.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NoMaps = @"No maps found! Creating an empty map.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString UpgradeBackup = @"Please make a backup of your game and player databases, then type '{00}' to continue or '{01}' to quit.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString UpgradeExit = @"EXIT";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString UpgradeReady = @"READY";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString UpgradeRequired = @"Your databases need to be upgraded! This process could corrupt your game data if any errors are encountered.";
    }

    public sealed partial class ErrorsNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ErrorFloodBurst = "[Flood]: {00} Burst Packets [User: {01} | Player: {02} | IP {03}]";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ErrorFloodSize = @"[Flood]: Packet Size: {00} [User: {01} | Player: {02} | IP {03}]";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ErrorLoadingConfiguration = @"Failed to load server options! Press any key to shut down.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ErrorLoadingStrings = @"Failed to load strings! Press any key to shut down.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ErrorLogged = @"An error was logged into errors.log.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ErrorServerCrash = @"The Intersect server has encountered an error and must close. Error information can be found in resources/logs/errors.log. Press enter to exit.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ErrorServerCrashNoHalt = @"The Intersect server has encountered an error and must close. Error information can be found in resources/logs/errors.log.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ErrorTimeout = @"Too many failed requests. Please wait and try again!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString UnknownErrorTryAgain = @"An unknown error occurred, please try again.";
    }

    public sealed partial class EventsNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString CommandParameter = @"\param";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString EventNameCommand = @"\en";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString EventParameter = @"\evtparam";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString EventParameters = @"\evtparams";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString GlobalSwitch = @"\gs";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString GlobalVariable = @"\gv";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString GuildVariable = @"\guildvar";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString MilitaryHour = @"\24hour";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString OnlineCountCommand = @"\onlinecount";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString OnlineListCommand = @"\onlinelist";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PeriodEvening = @"PM";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PeriodMorning = @"AM";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PlayerGuildCommand = @"\pg";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PlayerNameCommand = @"\pn";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PlayerSwitch = @"\ps";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PlayerVariable = @"\pv";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString TimeHour = @"\hour";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString TimeMinute = @"\minute";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString TimePeriod = @"\period";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString TimeSecond = @"\second";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString UserVariable = @"\uservar";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString WatchdogKill = @"Event killed due to commands processed in a single frame surpassing Event Watchdog Threshold. (Map: {00} Event: {01})";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString WatchdogKillCommon = @"Common event killed due to commands processed in a single frame surpassing the Event Watchdog Threshold. (Event {00})";
    }

    public sealed partial class FormulasNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Missing = @"Formulas.json file is missing. A default formulas file has been generated.";
    }

    public sealed partial class FriendsNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Accept = @"{00} has accepted your friend request!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString AlreadyFriends = @"You are already friends with {00}.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Busy = @"{00} is currently busy. Please try again later.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString FriendLoggedIn = @"{00} has logged in.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString FriendNotification = @"You are now friends with {00}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString FriendRemoved = @"Friend has been removed.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString FriendRequestSent = @"Friend request has been sent.";
    }

    public sealed partial class GeneralNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString DisabledLowerCase = @"disabled";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString EnabledLowerCase = @"enabled";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Notice = @"Notice";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NoticeError = @"Error Notice";
    }

    public sealed partial class GuildsNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString AlreadyInGuild = @"You are already in a guild!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Demoted = @"{00} has been demoted to {01}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString DisbandGuild = @"{00} has been disbanded!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString GuildChat = @"[{00}] {01}: {02}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString GuildCommand = @"/guild";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString GuildLeaderLeave = @"A Guildmaster cannot leave their own guild. Please transfer ownership rights first!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString GuildNameInUse = @"Your chosen guild name is already in use!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InviteAlreadyInGuild = @"The player you're trying to invite is already in a guild or has a pending invite.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InviteDeclined = @"You have declined the request to join {00}.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InviteDeclinedResponse = @"{00} has declined your request for them to join {01}.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InviteNotOnline = @"The player you're trying to invite is either not online or does not exist.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InviteSent = @"You've invited {00} to join {01}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NoLongerAllowedInInstance = @"You are no longer in the guild whose instance you were logged into. You have been warped back to the overworld.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NoSuchPlayer = @"There is no such player in this guild.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NotAllowed = @"You do not have permission to do this.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NotAllowedDeposit = @"You do not have permission to deposit items into {00}'s guild bank!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NotAllowedInInstance = @"You must be in a guild to warp to a guild instance.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NotAllowedSwap = @"You do not have permission to swap items around within {00}'s guild bank!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NotAllowedWithdraw = @"You do not have permission to withdraw from {00}'s guild bank!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NotInGuild = @"You are not in a guild.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NotReceivedInvite = @"You've not received any guild invites yet.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Promoted = @"{00} has been promoted to {01}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString RankLimit = @"Failed to join {00} because their guild is full!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString RankLimitResponse = @"This guild has already hit its member limit for the rank of {00}. Promote or demote other members to make room for {01}.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Transferred = @"Guild ownership of {00} has been transferred from {01} to {02}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString VariableInvalid = @"Invalid guild name!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString VariableNotString = @"The given guild name does not contain any text.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString Welcome = @"Welcome to {00}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString DeleteGuildLeader = @"You cannot delete a character that is a guild {00}. Please disband the guild or transfer ownership before trying again.";
    }

    public sealed partial class IntroNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString api = @"API listening on '{00}'.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString apifailed = @"Failed to start API.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString consoleactive =
            @"Type exit to shutdown the server, or help for a list of commands.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString exit = @"Press enter to exit.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString loading = @"Loading, please wait.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString started = @"Server Started. Using UDP Port #{00}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString support =
            @"For help, support, and updates visit: https://www.ascensiongamedev.com";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString tagline = @"                          free 2d orpg engine";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString title = @"Intersect Server";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString version = @"Version {00}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString websocketstarted =
            @"Websocket listener started for Unity WebGL Clients using Port #{00}";

    }

    public sealed partial class ItemsNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString bound = @"You cannot drop this item.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString nobag = @"You cannot store this item in a bag.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString nobank = @"You cannot store this item in a bank.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString cannotuse = @"You cannot use this item!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString cooldown = @"You must wait before using this item again!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString dynamicreq = @"You do not meet the requirements to use this item!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString equipped = @"You cannot drop equipped items.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString notenough = @"Not enough {00}s!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString notimplemented = @"Use of this item type is not yet implemented.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString sleep = @"You cannot use this item whilst asleep.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString statreq = @"You do not possess the correct combat stats to use this item.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString stunned = @"You cannot use this item whilst stunned.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NotYours = @"This item does not belong to you!";

        // TODO: Generalize this shit. It's everywhere!
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InventoryNoSpace =
            @"There is no space left in your inventory for that item!";

    }

    public sealed partial class MappingNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString lastmap = @"Last Map";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString lastmaperror =
            @"Failed to delete map, you must have at least one map at all times!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString linkfail = @"Map Link Failure";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString linkfailerror =
            @"Failed to link map {00} to map {01}. If this merge were to happen, maps {02} and {03} would occupy the same space in the world.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString newfolder = @"New Folder";

    }

    public sealed partial class MigrationNamespace : LocaleNamespace
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString AlreadyUsingProvider =
            @"   Migration Error: {00} database is already using {01}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString Cancel = @"   Press any other key to cancel migration.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString CurrentlyUsing = @"currently using {00}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString DefaultHost = @"localhost";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString DefaultPortMySql = @"3306";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString DefaultUsername = @"root";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString DefaultDatabase = "intersect_{00}_{01}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString EnterConnectionStringParameters = @"Please enter your connection string parameters:";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString GameDatabaseName = @"Game";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString LoggingDatabaseName = @"Logging";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString OptionMySql = @"   [2] Mysql";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString OptionSqlite = @"   [1] Sqlite";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString MigratingDbSet = @"Migrating entities in {00}...";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString MigrationCanceled = @"Migration Cancelled";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString MigrationComplete = @"Migration complete! Press enter to exit.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString MySqlConnecting = @"Please wait, attempting to connect to database...";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString MySqlConnectionError = @"Error opening db connection! Error: {00}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString MySqlNotEmpty =
            @"Database must be empty before migration! Please delete any tables before proceeding! Migration Cancelled.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString MySqlTryAgain =
            @"Would you like to try entering your connection info again? (y/n)  ";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString ConfirmCharacter = @"y";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString PlayerDatabaseName = @"Player";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString PromptDatabase = @"Database ({00}): ";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString PromptHost = @"Host ({00}): ";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString PromptPassword = @"Password (empty): ";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString PromptPort = @"Port ({00}): ";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString PromptUsername = @"User ({00}): ";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString SelectContext = @"Which database would you like to migrate:";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString SelectProvider = @"Select which engine to migrate the {00} database to:";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString SqliteRecommended = "Sqlite strongly recommended!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString SelectDatabase = @"    [{00}] {01} (currently using {02}) {03}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString SelectDatabaseType = @"    [{00}] {01}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString SelectGameDatabaseProvider =
            "   [1] Game Database ({00})  -  Sqlite Strongly Recommended!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString SelectGameDatabaseKey = @"1";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString SelectMySqlKey = @"2";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString SelectPlayerDatabaseProvider = "   [2] Player Database ({00})";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString SelectPlayerDatabaseKey = @"2";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString SelectSqliteKey = @"1";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString DatabaseFileAlreadyExists = @"{00} already exists, overwrite? (y/n)  ";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString StartingMigration =
            @"Starting migration, please wait! (This could take several minutes depending on the size of your game)";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString StoppingServer =
            @"Please wait, stopping server, and saving current database...";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString TryAgainCharacter = @"y";
    }

    public sealed partial class NetDebugNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString hastebin =
            @"Network Debug information uploaded to {00} (copied to clipboard) share this link with AGD when requesting for help getting your game online!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString pleasewait = @"Please wait while network diagnostics run....";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString savedtofile =
            @"Network Debug information saved to netdebug.txt! Upload that file and share it with AGD when requesting for help getting your game online!";

    }

    public sealed partial class NetworkingNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString badpacket =
            @"Error handling client packet. Disconnecting client. More info logged to errors.log";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString disconnected = @"Client disconnected.";


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString ServerFull = @"The server is currently full, please try again later.";

    }

    public sealed partial class NotificationsNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString copyright = "Copyright (C) 2020 Ascension Game Dev, All Rights Reserved";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString product = @"Intersect Game Engine";

    }

    public sealed partial class PartiesNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString alreadydenied = @"Your party invitation has already been rejected!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString busy = @"{00} is busy. Please try again later!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString declined = @"{00} has declined your party invitation!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString disbanded = @"The party has been disbanded.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InInstance = @"You cannot invite someone to a party while in an instance!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString inparty = @"{00} is already in a party!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString joined = @"{00} has joined the party!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString kicked = @"You have been kicked from the party!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString
            leaderinvonly = @"Only the party leader can send invitations to your party.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString left = @"You have left the party.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString limitreached =
            @"You have reached the maximum limit of party members. Kick another member before adding more.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString memberkicked = @"{00} has been kicked from the party!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString memberleft = @"{00} has left the party!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString notinparty = @"You are not in a party.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString outofrange = @"Target is out of range or offline.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InstanceInUse = @"Can not create new instance - party members are still in the old one.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString CannotCreateInstance = @"Only the party leader can create a shared instance.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InstanceInProgress = @"The party has not yet completed their instance.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString WrongInstance = @"Your party is currently doing a different instance.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InstanceLivesRemaining = @"Your party has {00} lives remaining on this instance!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString NoMoreLivesRemaining = @"Your party has no more lives remaining! You will respawn out of the instance on your next death.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString InstanceFailed = @"Your party has failed the instance...";

    }

    public sealed partial class PasswordResetNotificationNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString subject = @"Intersect Game Engine - Password Reset Code";

    }

    public sealed partial class PlayerNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString admin = @"{00} has been given administrative powers!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString adminjoined =
            @"You are an administrator! Press Insert at any time to access the administration menu or F2 for debug information.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString adminsetpower = @"Only admins can set power!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString InstanceUpdate = @"Your instance ID has changed from {00} to {01}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString OverworldReturnAdmin = @"You have returned {00} to the overworld.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString OverworldReturned = @"You have been returned to the overworld.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString beenwarpedto = @"You have been warped to {00}.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString changeownpower = @"You cannot alter your own power!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString deadmin = @"{00} has had their administrative powers revoked!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString demod = @"{00} has had their moderation powers revoked!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString haswarpedto = @"{00} has been warped to you.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString joined = @"{00} has joined {01}.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString kicked = @"{00} has been kicked by {01}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString killed = @"{00} has been killed by {01}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString left = @"{00} has left {01}.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString levelup = @"You have leveled up! You are now level {00}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString mod = @"{00} has been given moderation powers!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString modjoined =
            @"You are a moderator! Press Insert at any time to access the administration menu or F2 for debug information.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString notarget = @"You need to select a valid target.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString CannotWarpToYourself =
            @"You cannot warp to yourself.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString offline = @"User not online!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PlayerNotFound = @"The player '{00}' was not found!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString powerchanged = @"Your power has been modified!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString serverkicked = @"{00} has been kicked by the server!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString serverkilled = @"{00} has been killed by the server!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString spelltaughtlevelup = @"You've learned the {00} spell!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString statpoints = @"You have {00} stat points available to be spent!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString targetoutsiderange = @"Target not in range.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString warpedto = @"Warped to {00}.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString warpedtoyou = @"{00} warped to you.";

    }

    public sealed partial class PortcheckingNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString accessible = @"Your game is accesible to the public!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString checkantivirus =
            @"   2. Antivirus programs might also be blocking connections and you may need to add Intersect Server.exe to your antivirus exclusions.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString checkfirewalls =
            @"   1. Firewalls might be blocking connections to your server. Check firewalls on your system. (i.e. iptables, FirewallD, Windows Firewall)";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString checkrouterupnp =
            @"It appears that UPnP Failed. Your might need to enable UPnP on your router or manually port forward to allow connections to your server.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString connectioninfo = @"Connection Information:";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString debuggingsteps = @"Debugging Steps (To allow public access):";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString letothersjoin =
            @"Enter your public ip and port into the client/editor config for others to join!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString notaccessible =
            @"It does not appear that your game is accessible to the outside world.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString notconnected =
            @"   Could not retreive connection information from AGD servers. Do you have an internet connection?";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString publicip = @"   Public IP: {00}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString publicport = @"   Public Port: {00}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString screwed =
            @"   3. If on a college campus, or within a business network you likely do not have permission to open ports or host games in which case you should explore external hosting options!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocaleDictionary<PortCheckResult, LocalizedString> PortCheckerResults = new LocaleDictionary<PortCheckResult, LocalizedString>(
            new Dictionary<PortCheckResult, LocalizedString>
            {
                { PortCheckResult.Unknown, "This server is possibly inaccessible from the outside world, try to connect with the client to verify." },
                { PortCheckResult.Open, "This server is accessible from the outside world, properly configured clients can connect." },
                { PortCheckResult.PossiblyOpen, "This server is possible accessible from the outside world, but the AscensionGameDev port checker server gave an inconclusive response." },
                { PortCheckResult.IntersectResponseNoPlayerCount, "This server is not reporting a player count and may not be accessible, please see the Port Forwarding documentation for more information: {0}" },
                { PortCheckResult.IntersectResponseInvalidPlayerCount, "This server reporting an invalid player count and may not be accessible, please see the Port Forwarding documentation for more information: {0}" },
                { PortCheckResult.InvalidPortCheckerRequest, "The AscensionGameDev port checker server is down and this server may or may not be accessible from the outside world, try to connect with the client to verify" },
                { PortCheckResult.PortCheckerServerError, "The AscensionGameDev port checker server encountered an error and this server may or may not be accessible from the outside world, try to connect with the client to verify." },
                { PortCheckResult.PortCheckerServerDown, "The AscensionGameDev port checker server is down and this server may or may not be accessible from the outside world, try to connect with the client to verify" },
                { PortCheckResult.PortCheckerServerUnexpectedResponse, "The AscensionGameDev port checker server is down and this server may or may not be accessible from the outside world, try to connect with the client to verify" },
                { PortCheckResult.Inaccessible, "This server is not accessible from the outside world, please see the Port Forwarding documentation for more information: {0}" },
            }
        );

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString DocumentationUrl =
            @"https://docs.freemmorpgmaker.com/en-US/deploy/forwarding/";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PortNotOpenTryingUPnP = @"Port {0} is not open, trying UPnP...";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PortNotOpenUPnPDisabled = @"Port {0} is not open, but UPnP is disabled. Check your router port forwarding and computer firewall configurations.";
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString PortCheckerAndUPnPDisabled =
            @"The port checker service and UPnP have both been disabled, please verify the server status manually with a client.";
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString UPnPSucceededPortCheckerDisabled =
            @"UPnP succeeded but the port checker is disabled. Please verify the server status manually using a client.";
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString UPnPFailed =
            @"UPnP failed, please verify the server status manually using a client.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString TryingUPnP =
            @"Trying to open the port using UPnP...";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString ProbablyFirewall =
            @"UPnP supposedly succeeded but the server is not accessible on port {0}, check the firewall of the machine this server is running on.";
    }

    public sealed partial class QuestsNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString abandoned = @"Quest Abandoned: {00}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString completed = @"Quest: {00} completed!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString declined = @"Quest Declined: {00}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString itemtask = @"{00}  updated! {01}/{02} {03}(s) gathered!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString npctask = @"{00}  updated! {01}/{02} {03}(s) slain!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString started = @"Quest Started: {00}!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString taskcompleted = @"Task Completed!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString updated = @"Quest: {00} updated!";

    }

    public sealed partial class RegexNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString email =
            @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString
            password = @"^[-_=\+`~!@#\$%\^&\*()\[\]{}\\|;\:'"",<\.>/\?a-zA-Z0-9]{4,64}$";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString username = @"^[a-zA-Z0-9]{2,20}$";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString guildname = @"^[a-zA-Z0-9 ]{3,20}$";

    }

    public sealed partial class ShopsNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString bound = @"This item is bound to you and cannot be sold!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString TransactionFailed = @"Transaction failed!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString cantafford = @"Transaction failed due to insufficent funds.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString doesnotaccept = @"This shop does not accept that item!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString inventoryfull = @"You do not have space to purchase that item!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString SuccessfullyRemovedItem = @"Successfully took {00} items from slot {01} for player {02} at {03}";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString FailedRemovedItem = @"Failed to take items from slot {00} for player {01}. Quantity to remove: {02} at {03}";

    }

    public sealed partial class TradingNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString accepted = @"The trade was successful!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString alreadydenied = @"Your trade request has already been denied!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString bound = @"This item is bound to you and cannot be traded!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString busy = @"{00} is busy. Please try again later!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString declined = @"The trade was declined!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString inventorynospace =
            @"There is no space left in your inventory for that item!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString itemsdropped =
            @"Out of inventory space. Some of your items have been dropped on the ground!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString OfferAccepted = @"{00} has accepted your offer. Please confirm the trade.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString offerinvalid = @"Invalid item selected to offer!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString RevokeNotAllowed = @"You can't revoke this item, {00} already accepted the trade!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString outofrange = @"Trade target is out of range or offline.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString revokeinvalid = @"Invalid item selected to revoke!";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString tradenospace = @"There is no space left in the trade window for that item!";

    }

    public sealed partial class UpnpNamespace : LocaleNamespace
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString failedforwardingtcp =
            @"Failed to automatically port forward tcp port {00} using UPnP. (UPnP possibly disabled in your router settings, or this port might already be forwarded!)";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString failedforwardingudp =
            @"Failed to automatically port forward udp port {00} using UPnP. (UPnP possibly disabled in your router settings, or this port might already be forwarded!)";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString
            forwardedtcp = @"Successfully auto port forwarded tcp port {00} using UPnP.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString
            forwardedudp = @"Successfully auto port forwarded udp port {00} using UPnP.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public readonly LocalizedString initializationfailed =
            @"UPnP Service Initialization Failed. You might not have a router, or UPnP on your router might be disabled.";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] public readonly LocalizedString initialized = @"UPnP Service Initialization Succeeded";

    }

    #region Serialization

    public static bool Load()
    {
        var filepath = Path.Combine(ServerContext.ResourceDirectory, "server_strings.json");

        // Really don't want two JsonSave() return points...
        // ReSharper disable once InvertIf
        if (File.Exists(filepath))
        {
            var json = File.ReadAllText(filepath, Encoding.UTF8);
            try
            {
                Root = JsonConvert.DeserializeObject<RootNamespace>(json) ?? Root;
            }
            catch (Exception exception)
            {
                if (exception.Message.Contains("Commands.announcement"))
                {
                    throw new Exception(
                        "Server strings invalid! Upgrade steps to B6 were not followed correctly. Server must close!"
                    );
                }

                Log.Error(exception);

                return false;
            }
        }

        return Save();
    }

    public static bool Save()
    {
        try
        {
            var filepath = Path.Combine(ServerContext.ResourceDirectory, "server_strings.json");
            Directory.CreateDirectory(ServerContext.ResourceDirectory);
            var json = JsonConvert.SerializeObject(Root, Formatting.Indented, new LocalizedStringConverter());
            File.WriteAllText(filepath, json, Encoding.UTF8);

            return true;
        }
        catch (Exception exception)
        {
            Log.Error(exception);

            return false;
        }
    }

    #endregion

    #region Root Namespace

    static Strings()
    {
        Root = new RootNamespace();
    }

    private static RootNamespace Root { get; set; }

    // ReSharper disable MemberHidesStaticFromOuterClass
    private sealed partial class RootNamespace : LocaleNamespace
    {

        public readonly AccountNamespace Account = new AccountNamespace();

        public readonly BagNamespace Bags = new BagNamespace();

        public readonly BankNamespace Banks = new BankNamespace();

        public readonly ChatNamespace Chat = new ChatNamespace();

        public readonly ClassNamespace Classes = new ClassNamespace();

        public readonly ColorNamespace Colors = new ColorNamespace();

        public readonly CombatNamespace Combat = new CombatNamespace();

        public readonly CommandOutputNamespace Commandoutput = new CommandOutputNamespace();

        public readonly CommandsNamespace Commands = new CommandsNamespace();

        public readonly CraftingNamespace Crafting = new CraftingNamespace();

        public readonly DatabaseNamespace Database = new DatabaseNamespace();

        public readonly ErrorsNamespace Errors = new ErrorsNamespace();

        public readonly EventsNamespace Events = new EventsNamespace();

        public readonly FormulasNamespace Formulas = new FormulasNamespace();

        public readonly FriendsNamespace Friends = new FriendsNamespace();

        public readonly GeneralNamespace General = new GeneralNamespace();

        public readonly IntroNamespace Intro = new IntroNamespace();

        public readonly ItemsNamespace Items = new ItemsNamespace();

        public readonly MappingNamespace Mapping = new MappingNamespace();

        public readonly MigrationNamespace Migration = new MigrationNamespace();

        public readonly NetDebugNamespace NetDebug = new NetDebugNamespace();

        public readonly NetworkingNamespace Networking = new NetworkingNamespace();

        public readonly NotificationsNamespace NotificationsNamespace = new NotificationsNamespace();

        public readonly PartiesNamespace Parties = new PartiesNamespace();

        public readonly PasswordResetNotificationNamespace PasswordResetNotificationNamespace =
            new PasswordResetNotificationNamespace();

        public readonly PlayerNamespace Player = new PlayerNamespace();

        public readonly PortcheckingNamespace Portchecking = new PortcheckingNamespace();

        public readonly QuestsNamespace Quests = new QuestsNamespace();

        public readonly RegexNamespace Regex = new RegexNamespace();

        public readonly ShopsNamespace Shops = new ShopsNamespace();

        public readonly TradingNamespace Trading = new TradingNamespace();

        public readonly UpnpNamespace Upnp = new UpnpNamespace();

        public readonly GuildsNamespace Guilds = new GuildsNamespace();

    }

    // ReSharper restore MemberHidesStaticFromOuterClass

    #endregion

    #region Namespace Exposure

    public static AccountNamespace Account => Root.Account;

    public static BagNamespace Bags => Root.Bags;

    public static BankNamespace Banks => Root.Banks;

    public static ChatNamespace Chat => Root.Chat;

    public static ClassNamespace Classes => Root.Classes;

    public static ColorNamespace Colors => Root.Colors;

    public static CombatNamespace Combat => Root.Combat;

    public static CommandOutputNamespace Commandoutput => Root.Commandoutput;

    public static CommandsNamespace Commands => Root.Commands;

    public static CraftingNamespace Crafting => Root.Crafting;

    public static DatabaseNamespace Database => Root.Database;

    public static ErrorsNamespace Errors => Root.Errors;

    public static EventsNamespace Events => Root.Events;

    public static FormulasNamespace Formulas => Root.Formulas;

    public static FriendsNamespace Friends => Root.Friends;

    public static GeneralNamespace General => Root.General;

    public static GuildsNamespace Guilds => Root.Guilds;

    public static IntroNamespace Intro => Root.Intro;

    public static ItemsNamespace Items => Root.Items;

    public static MappingNamespace Mapping => Root.Mapping;

    public static MigrationNamespace Migration => Root.Migration;

    public static NetDebugNamespace NetDebug => Root.NetDebug;

    public static NetworkingNamespace Networking => Root.Networking;

    public static NotificationsNamespace Notifications => Root.NotificationsNamespace;

    public static PartiesNamespace Parties => Root.Parties;

    public static PasswordResetNotificationNamespace PasswordResetNotification =>
        Root.PasswordResetNotificationNamespace;

    public static PlayerNamespace Player => Root.Player;

    public static PortcheckingNamespace Portchecking => Root.Portchecking;

    public static QuestsNamespace Quests => Root.Quests;

    public static RegexNamespace Regex => Root.Regex;

    public static ShopsNamespace Shops => Root.Shops;

    public static TradingNamespace Trading => Root.Trading;

    public static UpnpNamespace Upnp => Root.Upnp;

    #endregion

}
