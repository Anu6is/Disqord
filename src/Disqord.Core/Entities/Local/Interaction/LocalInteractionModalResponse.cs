using System.Collections.Generic;
using Qommon;

namespace Disqord;

public class LocalInteractionModalResponse : ILocalInteractionResponse, ILocalCustomIdentifiableEntity, ILocalConstruct<LocalInteractionModalResponse>
{
    InteractionResponseType ILocalInteractionResponse.Type => InteractionResponseType.Modal;

    /// <summary>
    ///     Gets or sets the custom ID of this modal.
    /// </summary>
    /// <remarks>
    ///     This property is required.
    /// </remarks>
    public Optional<string> CustomId { get; set; }

    /// <summary>
    ///     Gets or sets the title of this modal.
    /// </summary>
    /// <remarks>
    ///     This property is required.
    /// </remarks>
    public Optional<string> Title { get; set; }

    /// <summary>
    ///     Gets or sets the components of this modal.
    /// </summary>
    public Optional<IList<LocalComponent>> Components { get; set; }

    public LocalInteractionModalResponse()
    { }

    protected LocalInteractionModalResponse(LocalInteractionModalResponse other)
    {
        CustomId = other.CustomId;
        Title = other.Title;
        Components = other.Components.DeepClone();
    }

    /// <inheritdoc/>
    public virtual LocalInteractionModalResponse Clone()
    {
        return new(this);
    }
}
