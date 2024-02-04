namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Occupancy;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Math;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Items;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(MinimapComponent))]
    [RequireComponent(typeof(LinkComponent))]
    [RequireComponent(typeof(CraftingComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
	[Tag("Usable")]
	
    public partial class MailboxObject : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(MailboxItem);
        public override LocString DisplayName => Localizer.DoStr("Mailbox");
        public override TableTextureMode TableTexture => TableTextureMode.Wood;

        protected override void Initialize()
        {
			this.GetComponent<MinimapComponent>().SetCategory(Localizer.DoStr("Crafting"));
        }
    }

    [Serialized]
    [LocDisplayName("Mailbox")]
    [Ecopedia("Work Stations", "Craft Tables", createAsSubPage: true)]
    public partial class MailboxItem : WorldObjectItem<MailboxObject>, IPersistentData
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext( 0  | DirectionAxisFlags.Down , WorldObject.GetOccupancyInfo(this.WorldObjectType));

        [Serialized, SyncToView, NewTooltipChildren(CacheAs.Instance, flags: TTFlags.AllowNonControllerTypeForChildren)] public object PersistentData { get; set; }
    }

    [RequiresSkill(typeof(CarpentrySkill), 2)]
    public partial class MailboxRecipe : RecipeFamily
    {
        public MailboxRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ERCWoodenComposter",
                displayName: Localizer.DoStr("Mailbox"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("WoodBoard", 25),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<MailboxItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.LaborInCalories = CreateLaborInCaloriesValue(30);
            this.CraftMinutes = CreateCraftTimeValue(0.5f);
            this.Initialize(displayText: Localizer.DoStr("Mailbox"), recipeType: typeof(MailboxRecipe));
            CraftingComponent.AddRecipe(tableType: typeof(CarpentryTableObject), recipe: this);
        }
    }
}
