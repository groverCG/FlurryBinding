using ObjCRuntime;

namespace FlurryAnalyticsNew
{
    [Native]
    public enum FlurryLogLevel : ulong
    {
        None = 0,
        CriticalOnly,
        Debug,
        All
    }

    [Native]
    public enum FlurryPaymentTransactionState : ulong
    {
        Purchasing = 0,
        Success = 1,
        Failure = 2,
        Restored = 3,
        Deferred = 4
    }

    [Native]
    public enum FlurryEventRecordStatus : ulong
    {
        Failed = 0,
        Recorded,
        UniqueCountExceeded,
        ParamsCountExceeded,
        LogCountExceeded,
        LoggingDelayed,
        AnalyticsDisabled,
        ParametersMismatched
    }

    [Native]
    public enum FlurrySyndicationEvent : ulong
    {
        Reblog = 0,
        FastReblog = 1,
        SourceClick = 2,
        Like = 3,
        ShareClick = 4,
        PostSend = 5
    }

    [Native]
    public enum FlurryTransactionRecordStatus : ulong
    {
        rdFailed = 0,
        rded,
        rdExceeded,
        dingDisabled
    }

    [Native]
    public enum FlurryStandardEventNameType : ulong
    {
        StringParamType = 0,
        IntegerParamType,
        DoubleParamType,
        BooleanParamType,
        LongParamType
    }

    [Native]
    public enum FlurryEvent : ulong
    {
        AdClick = 0,
        AdImpression,
        AdRewarded,
        AdSkipped,
        CreditsSpent,
        CreditsPurchased,
        CreditsEarned,
        AchievementUnlocked,
        LevelCompleted,
        LevelFailed,
        LevelUp,
        LevelStarted,
        LevelSkip,
        ScorePosted,
        ContentRated,
        ContentViewed,
        ContentSaved,
        ProductCustomized,
        AppActivated,
        ApplicationSubmitted,
        AddItemToCart,
        AddItemToWishList,
        CompletedCheckout,
        PaymentInfoAdded,
        ItemViewed,
        ItemListViewed,
        Purchased,
        PurchaseRefunded,
        RemoveItemFromCart,
        CheckoutInitiated,
        FundsDonated,
        UserScheduled,
        OfferPresented,
        SubscriptionStarted,
        SubscriptionEnded,
        GroupJoined,
        GroupLeft,
        TutorialStarted,
        TutorialCompleted,
        TutorialStepCompleted,
        TutorialSkipped,
        Login,
        Logout,
        UserRegistered,
        SearchResultViewed,
        KeywordSearched,
        LocationSearched,
        Invite,
        Share,
        Like,
        Comment,
        MediaCaptured,
        MediaStarted,
        MediaStopped,
        MediaPaused,
        PrivacyPromptDisplayed,
        PrivacyOptIn,
        PrivacyOptOut
    }

    [Native]
    public enum FlurryConversionValueEventType : ulong
    {
        NoEvent = 0,
        Registration,
        Login,
        Subscription,
        InAppPurchase
    }
}
