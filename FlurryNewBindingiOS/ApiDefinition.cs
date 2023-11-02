﻿using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using StoreKit;

namespace FlurryAnalyticsNew
{
    // @interface FlurryConsent : NSObject
    [BaseType(typeof(NSObject))]
    interface FlurryConsent
    {
        // @property (readonly, assign, nonatomic) BOOL isGDPRScope;
        [Export("isGDPRScope")]
        bool IsGDPRScope { get; }

        // @property (readonly, nonatomic, strong) NSDictionary * consentStrings;
        [Export("consentStrings", ArgumentSemantic.Strong)]
        NSDictionary ConsentStrings { get; }

        // -(FlurryConsent *)initWithGDPRScope:(BOOL)isGDPRScope andConsentStrings:(NSDictionary *)consentStrings;
        [Export("initWithGDPRScope:andConsentStrings:")]
        NativeHandle Constructor(bool isGDPRScope, NSDictionary consentStrings);

        // +(BOOL)updateConsentInformation:(FlurryConsent *)consent;
        [Static]
        [Export("updateConsentInformation:")]
        bool UpdateConsentInformation(FlurryConsent consent);

        // +(FlurryConsent *)getConsent;
        [Static]
        [Export("getConsent")]
        FlurryConsent Consent { get; }
    }

    // @interface FlurryCCPA : NSObject
    [BaseType(typeof(NSObject))]
    interface FlurryCCPA
    {
        // +(void)setDataSaleOptOut:(BOOL)isOptOut;
        [Static]
        [Export("setDataSaleOptOut:")]
        void SetDataSaleOptOut(bool isOptOut);

        // +(void)setDelete;
        [Static]
        [Export("setDelete")]
        void SetDelete();
    }

    // @interface FlurrySessionBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface FlurrySessionBuilder
    {
        // -(FlurrySessionBuilder *)withDataSaleOptOut:(BOOL)value;
        [Export("withDataSaleOptOut:")]
        FlurrySessionBuilder WithDataSaleOptOut(bool value);

        // -(FlurrySessionBuilder *)withAppVersion:(NSString *)value;
        [Export("withAppVersion:")]
        FlurrySessionBuilder WithAppVersion(string value);

        // -(FlurrySessionBuilder *)withSessionContinueSeconds:(NSInteger)value;
        [Export("withSessionContinueSeconds:")]
        FlurrySessionBuilder WithSessionContinueSeconds(nint value);

        // -(FlurrySessionBuilder *)withCrashReporting:(BOOL)value;
        [Export("withCrashReporting:")]
        FlurrySessionBuilder WithCrashReporting(bool value);

        // -(FlurrySessionBuilder *)withLogLevel:(FlurryLogLevel)value;
        [Export("withLogLevel:")]
        FlurrySessionBuilder WithLogLevel(FlurryLogLevel value);

        // -(FlurrySessionBuilder *)withShowErrorInLog:(BOOL)value;
        [Export("withShowErrorInLog:")]
        FlurrySessionBuilder WithShowErrorInLog(bool value);

        // -(FlurrySessionBuilder *)withConsent:(FlurryConsent *)consent;
        [Export("withConsent:")]
        FlurrySessionBuilder WithConsent(FlurryConsent consent);

        // -(FlurrySessionBuilder *)withIAPReportingEnabled:(BOOL)value;
        [Export("withIAPReportingEnabled:")]
        FlurrySessionBuilder WithIAPReportingEnabled(bool value);

        // -(FlurrySessionBuilder *)withIncludeBackgroundSessionsInMetrics:(BOOL)value;
        [Export("withIncludeBackgroundSessionsInMetrics:")]
        FlurrySessionBuilder WithIncludeBackgroundSessionsInMetrics(bool value);

        // -(FlurrySessionBuilder *)withSessionOrigin:(NSString *)origin;
        [Export("withSessionOrigin:")]
        FlurrySessionBuilder WithSessionOrigin(string origin);

        // -(FlurrySessionBuilder *)withSessionOriginVerion:(NSString *)version;
        [Export("withSessionOriginVerion:")]
        FlurrySessionBuilder WithSessionOriginVerion(string version);

        // -(FlurrySessionBuilder *)withSessionOriginParameters:(NSDictionary *)parameters;
        [Export("withSessionOriginParameters:")]
        FlurrySessionBuilder WithSessionOriginParameters(NSDictionary parameters);

        // -(FlurrySessionBuilder *)withSessionDeeplink:(NSString *)deeplink;
        [Export("withSessionDeeplink:")]
        FlurrySessionBuilder WithSessionDeeplink(string deeplink);

        // -(FlurrySessionBuilder *)withSessionProperties:(NSDictionary *)properties;
        [Export("withSessionProperties:")]
        FlurrySessionBuilder WithSessionProperties(NSDictionary properties);
    }

    [Static]
    partial interface Constants
    {
        // extern NSString *const _Nonnull kSyndicationiOSDeepLink;
        [Field("kSyndicationiOSDeepLink", "__Internal")]
        NSString kSyndicationiOSDeepLink { get; }

        // extern NSString *const _Nonnull kSyndicationAndroidDeepLink;
        [Field("kSyndicationAndroidDeepLink", "__Internal")]
        NSString kSyndicationAndroidDeepLink { get; }

        // extern NSString *const _Nonnull kSyndicationWebDeepLink;
        [Field("kSyndicationWebDeepLink", "__Internal")]
        NSString kSyndicationWebDeepLink { get; }

        // extern NSString *const _Nonnull FlurryPropertyCurrencyPreference;
        [Field("FlurryPropertyCurrencyPreference", "__Internal")]
        NSString FlurryPropertyCurrencyPreference { get; }

        // extern NSString *const _Nonnull FlurryPropertyPurchaser;
        [Field("FlurryPropertyPurchaser", "__Internal")]
        NSString FlurryPropertyPurchaser { get; }

        // extern NSString *const _Nonnull FlurryPropertyRegisteredUser;
        [Field("FlurryPropertyRegisteredUser", "__Internal")]
        NSString FlurryPropertyRegisteredUser { get; }

        // extern NSString *const _Nonnull FlurryPropertySubscriber;
        [Field("FlurryPropertySubscriber", "__Internal")]
        NSString FlurryPropertySubscriber { get; }
    }

    // @protocol FlurryDelegate <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface FlurryDelegate
    {
        // @required -(void)flurrySessionDidCreateWithInfo:(NSDictionary * _Nonnull)info;
        [Abstract]
        [Export("flurrySessionDidCreateWithInfo:")]
        void FlurrySessionDidCreateWithInfo(NSDictionary info);
    }

    // @protocol FlurryFetchObserver <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface FlurryFetchObserver
    {
        // @optional -(void)onFetched:(NSDictionary<NSString *,NSString *> * _Nullable)publisherData;
        [Export("onFetched:")]
        void OnFetched([NullAllowed] NSDictionary<NSString, NSString> publisherData);
    }

    // @interface Flurry : NSObject
    [BaseType(typeof(NSObject))]
    interface Flurry
    {
        // +(NSString * _Nonnull)getFlurryAgentVersion;
        [Static]
        [Export("getFlurryAgentVersion")]
        string FlurryAgentVersion { get; }

        // +(void)setShowErrorInLogEnabled:(BOOL)value;
        [Static]
        [Export("setShowErrorInLogEnabled:")]
        void SetShowErrorInLogEnabled(bool value);

        // +(void)setLogLevel:(FlurryLogLevel)value;
        [Static]
        [Export("setLogLevel:")]
        void SetLogLevel(FlurryLogLevel value);

        // +(void)setDelegate:(id<FlurryDelegate> _Nonnull)delegate;
        [Static]
        [Export("setDelegate:")]
        void SetDelegate(FlurryDelegate @delegate);

        // +(void)setDelegate:(id<FlurryDelegate> _Nonnull)delegate withCallbackQueue:(dispatch_queue_t _Nonnull)flurryCallbackQueue;
        [Static]
        [Export("setDelegate:withCallbackQueue:")]
        void SetDelegate(FlurryDelegate @delegate, DispatchQueue flurryCallbackQueue);

        // +(void)startSession:(NSString * _Nonnull)apiKey;
        [Static]
        [Export("startSession:")]
        void StartSession(string apiKey);

        // +(void)startSession:(NSString * _Nonnull)apiKey withOptions:(id _Nullable)options;
        [Static]
        [Export("startSession:withOptions:")]
        void StartSession(string apiKey, [NullAllowed] NSObject options);

        // +(void)startSession:(NSString * _Nonnull)apiKey withOptions:(id _Nullable)options withSessionBuilder:(FlurrySessionBuilder * _Nullable)sessionBuilder;
        [Static]
        [Export("startSession:withOptions:withSessionBuilder:")]
        void StartSession(string apiKey, [NullAllowed] NSObject options, [NullAllowed] FlurrySessionBuilder sessionBuilder);

        // +(void)startSession:(NSString * _Nonnull)apiKey withSessionBuilder:(FlurrySessionBuilder * _Nullable)sessionBuilder;
        [Static]
        [Export("startSession:withSessionBuilder:")]
        void StartSession(string apiKey, [NullAllowed] FlurrySessionBuilder sessionBuilder);

        // +(BOOL)activeSessionExists;
        [Static]
        [Export("activeSessionExists")]
        bool ActiveSessionExists { get; }

        // +(NSString * _Nonnull)getSessionID;
        [Static]
        [Export("getSessionID")]
        string SessionID { get; }

        // +(void)pauseBackgroundSession;
        [Static]
        [Export("pauseBackgroundSession")]
        void PauseBackgroundSession();

        // +(void)setUserID:(NSString * _Nullable)userID;
        [Static]
        [Export("setUserID:")]
        void SetUserID([NullAllowed] string userID);

        // +(void)setAge:(int)age;
        [Static]
        [Export("setAge:")]
        void SetAge(int age);

        // +(void)setGender:(NSString * _Nonnull)gender;
        [Static]
        [Export("setGender:")]
        void SetGender(string gender);

        // +(BOOL)trackPreciseLocation:(BOOL)state;
        [Static]
        [Export("trackPreciseLocation:")]
        bool TrackPreciseLocation(bool state);

        // +(void)setSessionReportsOnCloseEnabled:(BOOL)sendSessionReportsOnClose __attribute__((deprecated("")));
        [Static]
        [Export("setSessionReportsOnCloseEnabled:")]
        void SetSessionReportsOnCloseEnabled(bool sendSessionReportsOnClose);

        // +(void)setSessionReportsOnPauseEnabled:(BOOL)setSessionReportsOnPauseEnabled __attribute__((deprecated("")));
        [Static]
        [Export("setSessionReportsOnPauseEnabled:")]
        void SetSessionReportsOnPauseEnabled(bool setSessionReportsOnPauseEnabled);

        // +(void)setIAPReportingEnabled:(BOOL)value;
        [Static]
        [Export("setIAPReportingEnabled:")]
        void SetIAPReportingEnabled(bool value);

        // +(void)addSessionOrigin:(NSString * _Nonnull)sessionOriginName;
        [Static]
        [Export("addSessionOrigin:")]
        void AddSessionOrigin(string sessionOriginName);

        // +(void)addSessionOrigin:(NSString * _Nonnull)sessionOriginName withDeepLink:(NSString * _Nonnull)deepLink;
        [Static]
        [Export("addSessionOrigin:withDeepLink:")]
        void AddSessionOrigin(string sessionOriginName, string deepLink);

        // +(void)sessionProperties:(NSDictionary * _Nonnull)parameters;
        [Static]
        [Export("sessionProperties:")]
        void SessionProperties(NSDictionary parameters);

        // +(void)addOrigin:(NSString * _Nonnull)originName withVersion:(NSString * _Nonnull)originVersion;
        [Static]
        [Export("addOrigin:withVersion:")]
        void AddOrigin(string originName, string originVersion);

        // +(void)addOrigin:(NSString * _Nonnull)originName withVersion:(NSString * _Nonnull)originVersion withParameters:(NSDictionary * _Nullable)parameters;
        [Static]
        [Export("addOrigin:withVersion:withParameters:")]
        void AddOrigin(string originName, string originVersion, [NullAllowed] NSDictionary parameters);

        // +(FlurryEventRecordStatus)logEvent:(NSString * _Nonnull)eventName;
        [Static]
        [Export("logEvent:")]
        FlurryEventRecordStatus LogEvent(string eventName);

        // +(FlurryEventRecordStatus)logEvent:(NSString * _Nonnull)eventName withParameters:(NSDictionary * _Nullable)parameters;
        [Static]
        [Export("logEvent:withParameters:")]
        FlurryEventRecordStatus LogEvent(string eventName, [NullAllowed] NSDictionary parameters);

        // +(FlurryEventRecordStatus)logEvent:(FlurrySyndicationEvent)syndicationEvent syndicationID:(NSString * _Nonnull)syndicationID parameters:(NSDictionary * _Nullable)parameters;
        [Static]
        [Export("logEvent:syndicationID:parameters:")]
        FlurryEventRecordStatus LogEvent(FlurrySyndicationEvent syndicationEvent, string syndicationID, [NullAllowed] NSDictionary parameters);

        // +(void)logPaymentTransaction:(SKPaymentTransaction * _Nonnull)transaction statusCallback:(void (^ _Nullable)(FlurryTransactionRecordStatus))statusCallback;
        [Static]
        [Export("logPaymentTransaction:statusCallback:")]
        void LogPaymentTransaction(SKPaymentTransaction transaction, [NullAllowed] Action<FlurryTransactionRecordStatus> statusCallback);

        // +(void)logPaymentTransactionParamsWithTransactionId:(NSString * _Nonnull)transactionId productId:(NSString * _Nonnull)productId quantity:(NSString * _Nonnull)quantity price:(NSString * _Nonnull)price currency:(NSString * _Nonnull)currency productName:(NSString * _Nonnull)productName transactionState:(NSString * _Nonnull)transactionState userDefinedParams:(NSDictionary * _Nullable)transactionParams statusCallback:(void (^ _Nullable)(FlurryTransactionRecordStatus))statusCallback __attribute__((deprecated("use +logFlurryPaymentTransactionParamsWithTransactionId:productId:quantity:price:currency:productName:transactionState:userDefinedParams:statusCallback:")));
        [Static]
        [Export("logPaymentTransactionParamsWithTransactionId:productId:quantity:price:currency:productName:transactionState:userDefinedParams:statusCallback:")]
        void LogPaymentTransactionParamsWithTransactionId(string transactionId, string productId, string quantity, string price, string currency, string productName, string transactionState, [NullAllowed] NSDictionary transactionParams, [NullAllowed] Action<FlurryTransactionRecordStatus> statusCallback);

        // +(void)logFlurryPaymentTransactionParamsWithTransactionId:(NSString * _Nonnull)transactionId productId:(NSString * _Nonnull)productId quantity:(NSUInteger * _Nonnull)quantity price:(NSDecimalNumber * _Nonnull)price currency:(NSString * _Nonnull)currency productName:(NSString * _Nonnull)productName transactionState:(FlurryPaymentTransactionState)transactionState userDefinedParams:(NSDictionary * _Nullable)transactionParams statusCallback:(void (^ _Nullable)(FlurryTransactionRecordStatus))statusCallback __attribute__((deprecated("use +logPaymentTransactionWithTransactionId:productId:quantity:price:currency:productName:transactionState:userDefinedParams:statusCallback:")));
        [Static]
        [Export("logFlurryPaymentTransactionParamsWithTransactionId:productId:quantity:price:currency:productName:transactionState:userDefinedParams:statusCallback:")]
        unsafe void LogFlurryPaymentTransactionParamsWithTransactionId(string transactionId, string productId, nuint* quantity, NSDecimalNumber price, string currency, string productName, FlurryPaymentTransactionState transactionState, [NullAllowed] NSDictionary transactionParams, [NullAllowed] Action<FlurryTransactionRecordStatus> statusCallback);

        // +(void)logPaymentTransactionWithTransactionId:(NSString * _Nonnull)transactionId productId:(NSString * _Nonnull)productId quantity:(NSUInteger)quantity price:(double)price currency:(NSString * _Nonnull)currency productName:(NSString * _Nonnull)productName transactionState:(FlurryPaymentTransactionState)transactionState userDefinedParams:(NSDictionary * _Nullable)transactionParams statusCallback:(void (^ _Nullable)(FlurryTransactionRecordStatus))statusCallback;
        [Static]
        [Export("logPaymentTransactionWithTransactionId:productId:quantity:price:currency:productName:transactionState:userDefinedParams:statusCallback:")]
        void LogPaymentTransactionWithTransactionId(string transactionId, string productId, nuint quantity, double price, string currency, string productName, FlurryPaymentTransactionState transactionState, [NullAllowed] NSDictionary transactionParams, [NullAllowed] Action<FlurryTransactionRecordStatus> statusCallback);

        // +(FlurryEventRecordStatus)logEvent:(NSString * _Nonnull)eventName timed:(BOOL)timed;
        [Static]
        [Export("logEvent:timed:")]
        FlurryEventRecordStatus LogEvent(string eventName, bool timed);

        // +(FlurryEventRecordStatus)logEvent:(NSString * _Nonnull)eventName withParameters:(NSDictionary * _Nullable)parameters timed:(BOOL)timed;
        [Static]
        [Export("logEvent:withParameters:timed:")]
        FlurryEventRecordStatus LogEvent(string eventName, [NullAllowed] NSDictionary parameters, bool timed);

        // +(void)endTimedEvent:(NSString * _Nonnull)eventName withParameters:(NSDictionary * _Nullable)parameters;
        [Static]
        [Export("endTimedEvent:withParameters:")]
        void EndTimedEvent(string eventName, [NullAllowed] NSDictionary parameters);

        // +(void)logError:(NSString * _Nonnull)errorID message:(NSString * _Nullable)message exception:(NSException * _Nullable)exception;
        [Static]
        [Export("logError:message:exception:")]
        void LogError(string errorID, [NullAllowed] string message, [NullAllowed] NSException exception);

        // +(void)logError:(NSString * _Nonnull)errorID message:(NSString * _Nullable)message exception:(NSException * _Nullable)exception withParameters:(NSDictionary * _Nullable)parameters;
        [Static]
        [Export("logError:message:exception:withParameters:")]
        void LogError(string errorID, [NullAllowed] string message, [NullAllowed] NSException exception, [NullAllowed] NSDictionary parameters);

        // +(void)logError:(NSString * _Nonnull)errorID message:(NSString * _Nullable)message error:(NSError * _Nullable)error;
        [Static]
        [Export("logError:message:error:")]
        void LogError(string errorID, [NullAllowed] string message, [NullAllowed] NSError error);

        // +(void)logError:(NSString * _Nonnull)errorID message:(NSString * _Nullable)message error:(NSError * _Nullable)error withParameters:(NSDictionary * _Nullable)parameters;
        [Static]
        [Export("logError:message:error:withParameters:")]
        void LogError(string errorID, [NullAllowed] string message, [NullAllowed] NSError error, [NullAllowed] NSDictionary parameters);

        // +(void)leaveBreadcrumb:(NSString * _Nonnull)breadcrumb;
        [Static]
        [Export("leaveBreadcrumb:")]
        void LeaveBreadcrumb(string breadcrumb);

        // +(void)openPrivacyDashboard:(void (^ _Nullable)(BOOL))completionHandler;
        [Static]
        [Export("openPrivacyDashboard:")]
        void OpenPrivacyDashboard([NullAllowed] Action<bool> completionHandler);

        // +(BOOL)isFetchFinished;
        [Static]
        [Export("isFetchFinished")]
        bool IsFetchFinished { get; }

        // +(void)registerFetchObserver:(id<FlurryFetchObserver> _Nonnull)observer withExecutionQueue:(dispatch_queue_t _Nonnull)queue;
        [Static]
        [Export("registerFetchObserver:withExecutionQueue:")]
        void RegisterFetchObserver(FlurryFetchObserver observer, DispatchQueue queue);

        // +(void)unregisterFetchObserver:(id<FlurryFetchObserver> _Nonnull)observer;
        [Static]
        [Export("unregisterFetchObserver:")]
        void UnregisterFetchObserver(FlurryFetchObserver observer);

        // +(NSDictionary<NSString *,NSString *> * _Nullable)getPublisherData;
        [Static]
        [NullAllowed, Export("getPublisherData")]
        NSDictionary<NSString, NSString> PublisherData { get; }

        // +(void)fetch;
        [Static]
        [Export("fetch")]
        void Fetch();

        // +(void)setAppVersion:(NSString * _Nonnull)version;
        [Static]
        [Export("setAppVersion:")]
        void SetAppVersion(string version);

        // +(void)setSessionContinueSeconds:(int)seconds;
        [Static]
        [Export("setSessionContinueSeconds:")]
        void SetSessionContinueSeconds(int seconds);

        // +(void)setCountBackgroundSessions:(BOOL)value;
        [Static]
        [Export("setCountBackgroundSessions:")]
        void SetCountBackgroundSessions(bool value);
    }

    // @interface FlurryParam : NSObject
    [BaseType(typeof(NSObject))]
    interface FlurryParam
    {
    }

    // @interface FlurryStringParam : FlurryParam
    [BaseType(typeof(FlurryParam))]
    interface FlurryStringParam
    {
    }

    // @interface FlurryIntegerParam : FlurryParam
    [BaseType(typeof(FlurryParam))]
    interface FlurryIntegerParam
    {
    }

    // @interface FlurryDoubleParam : FlurryParam
    [BaseType(typeof(FlurryParam))]
    interface FlurryDoubleParam
    {
    }

    // @interface FlurryLongParam : FlurryParam
    [BaseType(typeof(FlurryParam))]
    interface FlurryLongParam
    {
    }

    // @interface FlurryBooleanParam : FlurryParam
    [BaseType(typeof(FlurryParam))]
    interface FlurryBooleanParam
    {
    }

    // @interface FlurryParamBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface FlurryParamBuilder
    {
        // +(FlurryStringParam * _Nonnull)adType;
        [Static]
        [Export("adType")]
        FlurryStringParam AdType { get; }

        // +(FlurryStringParam * _Nonnull)levelName;
        [Static]
        [Export("levelName")]
        FlurryStringParam LevelName { get; }

        // +(FlurryIntegerParam * _Nonnull)levelNumber;
        [Static]
        [Export("levelNumber")]
        FlurryIntegerParam LevelNumber { get; }

        // +(FlurryStringParam * _Nonnull)contentName;
        [Static]
        [Export("contentName")]
        FlurryStringParam ContentName { get; }

        // +(FlurryStringParam * _Nonnull)contentType;
        [Static]
        [Export("contentType")]
        FlurryStringParam ContentType { get; }

        // +(FlurryStringParam * _Nonnull)contentId;
        [Static]
        [Export("contentId")]
        FlurryStringParam ContentId { get; }

        // +(FlurryStringParam * _Nonnull)creditName;
        [Static]
        [Export("creditName")]
        FlurryStringParam CreditName { get; }

        // +(FlurryStringParam * _Nonnull)creditType;
        [Static]
        [Export("creditType")]
        FlurryStringParam CreditType { get; }

        // +(FlurryStringParam * _Nonnull)creditId;
        [Static]
        [Export("creditId")]
        FlurryStringParam CreditId { get; }

        // +(FlurryStringParam * _Nonnull)currencyType;
        [Static]
        [Export("currencyType")]
        FlurryStringParam CurrencyType { get; }

        // +(FlurryBooleanParam * _Nonnull)isCurrencySoft;
        [Static]
        [Export("isCurrencySoft")]
        FlurryBooleanParam IsCurrencySoft { get; }

        // +(FlurryStringParam * _Nonnull)itemName;
        [Static]
        [Export("itemName")]
        FlurryStringParam ItemName { get; }

        // +(FlurryStringParam * _Nonnull)itemType;
        [Static]
        [Export("itemType")]
        FlurryStringParam ItemType { get; }

        // +(FlurryStringParam * _Nonnull)itemId;
        [Static]
        [Export("itemId")]
        FlurryStringParam ItemId { get; }

        // +(FlurryIntegerParam * _Nonnull)itemCount;
        [Static]
        [Export("itemCount")]
        FlurryIntegerParam ItemCount { get; }

        // +(FlurryStringParam * _Nonnull)itemCategory;
        [Static]
        [Export("itemCategory")]
        FlurryStringParam ItemCategory { get; }

        // +(FlurryStringParam * _Nonnull)itemListType;
        [Static]
        [Export("itemListType")]
        FlurryStringParam ItemListType { get; }

        // +(FlurryDoubleParam * _Nonnull)price;
        [Static]
        [Export("price")]
        FlurryDoubleParam Price { get; }

        // +(FlurryDoubleParam * _Nonnull)totalAmount;
        [Static]
        [Export("totalAmount")]
        FlurryDoubleParam TotalAmount { get; }

        // +(FlurryStringParam * _Nonnull)achievementId;
        [Static]
        [Export("achievementId")]
        FlurryStringParam AchievementId { get; }

        // +(FlurryIntegerParam * _Nonnull)score;
        [Static]
        [Export("score")]
        FlurryIntegerParam Score { get; }

        // +(FlurryStringParam * _Nonnull)rating;
        [Static]
        [Export("rating")]
        FlurryStringParam Rating { get; }

        // +(FlurryStringParam * _Nonnull)transactionId;
        [Static]
        [Export("transactionId")]
        FlurryStringParam TransactionId { get; }

        // +(FlurryBooleanParam * _Nonnull)success;
        [Static]
        [Export("success")]
        FlurryBooleanParam Success { get; }

        // +(FlurryStringParam * _Nonnull)paymentType;
        [Static]
        [Export("paymentType")]
        FlurryStringParam PaymentType { get; }

        // +(FlurryBooleanParam * _Nonnull)isAnnualSubscription;
        [Static]
        [Export("isAnnualSubscription")]
        FlurryBooleanParam IsAnnualSubscription { get; }

        // +(FlurryStringParam * _Nonnull)subscriptionCountry;
        [Static]
        [Export("subscriptionCountry")]
        FlurryStringParam SubscriptionCountry { get; }

        // +(FlurryIntegerParam * _Nonnull)trialDays;
        [Static]
        [Export("trialDays")]
        FlurryIntegerParam TrialDays { get; }

        // +(FlurryStringParam * _Nonnull)predictedLTV;
        [Static]
        [Export("predictedLTV")]
        FlurryStringParam PredictedLTV { get; }

        // +(FlurryStringParam * _Nonnull)groupName;
        [Static]
        [Export("groupName")]
        FlurryStringParam GroupName { get; }

        // +(FlurryIntegerParam * _Nonnull)stepNumber;
        [Static]
        [Export("stepNumber")]
        FlurryIntegerParam StepNumber { get; }

        // +(FlurryStringParam * _Nonnull)tutorialName;
        [Static]
        [Export("tutorialName")]
        FlurryStringParam TutorialName { get; }

        // +(FlurryStringParam * _Nonnull)userId;
        [Static]
        [Export("userId")]
        FlurryStringParam UserId { get; }

        // +(FlurryStringParam * _Nonnull)method;
        [Static]
        [Export("method")]
        FlurryStringParam Method { get; }

        // +(FlurryStringParam * _Nonnull)query;
        [Static]
        [Export("query")]
        FlurryStringParam Query { get; }

        // +(FlurryStringParam * _Nonnull)searchType;
        [Static]
        [Export("searchType")]
        FlurryStringParam SearchType { get; }

        // +(FlurryStringParam * _Nonnull)socialContentName;
        [Static]
        [Export("socialContentName")]
        FlurryStringParam SocialContentName { get; }

        // +(FlurryStringParam * _Nonnull)socialContentId;
        [Static]
        [Export("socialContentId")]
        FlurryStringParam SocialContentId { get; }

        // +(FlurryStringParam * _Nonnull)likeType;
        [Static]
        [Export("likeType")]
        FlurryStringParam LikeType { get; }

        // +(FlurryStringParam * _Nonnull)mediaName;
        [Static]
        [Export("mediaName")]
        FlurryStringParam MediaName { get; }

        // +(FlurryStringParam * _Nonnull)mediaType;
        [Static]
        [Export("mediaType")]
        FlurryStringParam MediaType { get; }

        // +(FlurryStringParam * _Nonnull)mediaId;
        [Static]
        [Export("mediaId")]
        FlurryStringParam MediaId { get; }

        // +(FlurryIntegerParam * _Nonnull)duration;
        [Static]
        [Export("duration")]
        FlurryIntegerParam Duration { get; }

        // -(NSDictionary<NSString *,NSString *> * _Nonnull)parameters;
        [Export("parameters")]
        NSDictionary<NSString, NSString> Parameters { get; }

        // -(FlurryParamBuilder * _Nonnull)setString:(NSString * _Nonnull)val forKey:(NSString * _Nonnull)key;
        [Export("setString:forKey:")]
        FlurryParamBuilder SetString(string val, string key);

        // -(FlurryParamBuilder * _Nonnull)setString:(NSString * _Nonnull)val forParam:(FlurryStringParam * _Nonnull)key;
        [Export("setString:forParam:")]
        FlurryParamBuilder SetString(string val, FlurryStringParam key);

        // -(FlurryParamBuilder * _Nonnull)setInteger:(int)val forKey:(NSString * _Nonnull)key;
        [Export("setInteger:forKey:")]
        FlurryParamBuilder SetInteger(int val, string key);

        // -(FlurryParamBuilder * _Nonnull)setInteger:(int)val forParam:(FlurryIntegerParam * _Nonnull)key;
        [Export("setInteger:forParam:")]
        FlurryParamBuilder SetInteger(int val, FlurryIntegerParam key);

        // -(FlurryParamBuilder * _Nonnull)setLong:(long)val forKey:(NSString * _Nonnull)key;
        [Export("setLong:forKey:")]
        FlurryParamBuilder SetLong(nint val, string key);

        // -(FlurryParamBuilder * _Nonnull)setLong:(long)val forParam:(FlurryLongParam * _Nonnull)key;
        [Export("setLong:forParam:")]
        FlurryParamBuilder SetLong(nint val, FlurryLongParam key);

        // -(FlurryParamBuilder * _Nonnull)setBoolean:(BOOL)val forKey:(NSString * _Nonnull)key;
        [Export("setBoolean:forKey:")]
        FlurryParamBuilder SetBoolean(bool val, string key);

        // -(FlurryParamBuilder * _Nonnull)setBoolean:(BOOL)val forParam:(FlurryBooleanParam * _Nonnull)key;
        [Export("setBoolean:forParam:")]
        FlurryParamBuilder SetBoolean(bool val, FlurryBooleanParam key);

        // -(FlurryParamBuilder * _Nonnull)setDouble:(double)val forKey:(NSString * _Nonnull)key;
        [Export("setDouble:forKey:")]
        FlurryParamBuilder SetDouble(double val, string key);

        // -(FlurryParamBuilder * _Nonnull)setDouble:(double)val forParam:(FlurryDoubleParam * _Nonnull)key;
        [Export("setDouble:forParam:")]
        FlurryParamBuilder SetDouble(double val, FlurryDoubleParam key);

        // -(FlurryParamBuilder * _Nonnull)removeObjectForKey:(id _Nonnull)key;
        [Export("removeObjectForKey:")]
        FlurryParamBuilder RemoveObjectForKey(NSObject key);

        // -(FlurryParamBuilder * _Nonnull)setAll:(FlurryParamBuilder * _Nonnull)param;
        [Export("setAll:")]
        FlurryParamBuilder SetAll(FlurryParamBuilder param);
    }

    // @interface Event (Flurry)
    [Category]
    [BaseType(typeof(Flurry))]
    interface Flurry_Event
    {
        // +(FlurryEventRecordStatus)logStandardEvent:(FlurryEvent)eventType withParameters:(FlurryParamBuilder * _Nullable)parameters;
        [Static]
        [Export("logStandardEvent:withParameters:")]
        FlurryEventRecordStatus LogStandardEvent(FlurryEvent eventType, [NullAllowed] FlurryParamBuilder parameters);
    }

    // @interface FlurrySKAdNetwork : NSObject
    [BaseType(typeof(NSObject))]
    interface FlurrySKAdNetwork
    {
        // +(void)flurryUpdateConversionValueWithEvent:(FlurryConversionValueEventType)event __attribute__((availability(ios, introduced=14.0)));
        //[iOS(14, 0)]
        [Static]
        [Export("flurryUpdateConversionValueWithEvent:")]
        void FlurryUpdateConversionValueWithEvent(FlurryConversionValueEventType @event);

        // +(void)flurryUpdateConversionValue:(NSInteger)conversionValue __attribute__((availability(ios, introduced=14.0)));
        //[iOS(14, 0)]
        [Static]
        [Export("flurryUpdateConversionValue:")]
        void FlurryUpdateConversionValue(nint conversionValue);
    }

    // @interface FlurryUserProperties : NSObject
    [BaseType(typeof(NSObject))]
    interface FlurryUserProperties
    {
        // +(void)set:(NSString * _Nonnull)propertyName values:(NSArray * _Nonnull)propertyValues;
        [Static]
        [Export("set:values:")]
        void Set(string propertyName, NSObject[] propertyValues);

        // +(void)set:(NSString * _Nonnull)propertyName value:(NSString * _Nonnull)propertyValue;
        [Static]
        [Export("set:value:")]
        void Set(string propertyName, string propertyValue);

        // +(void)add:(NSString * _Nonnull)propertyName values:(NSArray * _Nonnull)propertyValues;
        [Static]
        [Export("add:values:")]
        void Add(string propertyName, NSObject[] propertyValues);

        // +(void)add:(NSString * _Nonnull)propertyName value:(NSString * _Nonnull)propertyValue;
        [Static]
        [Export("add:value:")]
        void Add(string propertyName, string propertyValue);

        // +(void)remove:(NSString * _Nonnull)propertyName values:(NSArray * _Nonnull)propertyValues;
        [Static]
        [Export("remove:values:")]
        void Remove(string propertyName, NSObject[] propertyValues);

        // +(void)remove:(NSString * _Nonnull)propertyName value:(NSString * _Nonnull)propertyValue;
        [Static]
        [Export("remove:value:")]
        void Remove(string propertyName, string propertyValue);

        // +(void)remove:(NSString * _Nonnull)propertyName;
        [Static]
        [Export("remove:")]
        void Remove(string propertyName);

        // +(void)flag:(NSString * _Nonnull)propertyName;
        [Static]
        [Export("flag:")]
        void Flag(string propertyName);
    }

    // @interface StaticFlurryOBJC : NSObject
    //[BaseType(typeof(NSObject))]
    //interface StaticFlurryOBJC
    //{
    //}
}
