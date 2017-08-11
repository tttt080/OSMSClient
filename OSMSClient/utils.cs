using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSMSClient
{
    class utils
    {
        public static crm_aspect_monitor_aod TransToAod(object t)
        {
            crm_aspect_monitor_aod aodaspect = new crm_aspect_monitor_aod();
            crm_aspect_monitor_aod2 c = (crm_aspect_monitor_aod2)t;
            aodaspect.serviceId = c.serviceid;
            aodaspect.service = c.service;
            aodaspect.status = c.status;
            aodaspect.agentsInAccept = c.agentsInAccept;
            aodaspect.agentsInActive = c.agentsInActive;
            aodaspect.agentsInConnect = c.agentsInConnect;
            aodaspect.agentsInHold = c.agentsInHold;
            aodaspect.agentsInHdle = c.agentsInHdle;
            aodaspect.agentsInInternal = c.agentsInInternal;
            aodaspect.agentsInManual = c.agentsInManual;
            aodaspect.agentsInMultil = c.agentsInMultil;
            aodaspect.agentsInNotReady = c.agentsInNotReady;
            aodaspect.agentsInOther = c.agentsInOther;
            aodaspect.agentsInPark = c.agentsInPark;
            aodaspect.agentsInPreview = c.agentsInPreview;
            aodaspect.agentsInWrap = c.agentsInWrap;
            aodaspect.agentsLoggedIn = c.agentsLoggedIn;
            aodaspect.application = c.application;
            aodaspect.applicationId = c.applicationId;
            aodaspect.avgAgentActiveTime = c.avgAgentActiveTime;
            aodaspect.avgAgentIdleTime = c.avgAgentIdleTime;
            aodaspect.avgAgentWrapTime = c.avgAgentWrapTime;
            aodaspect.callsAnswered = c.callsAnswered;
            aodaspect.callsInProgress = c.callsInProgress;
            aodaspect.callsInQueue = c.callsInQueue;
            aodaspect.callsServicedWithInServiceLevelDaily = c.callsServicedWithInServiceLevelDaily;
            aodaspect.callsTransferredToAgent = c.callsTransferredToAgent;
            aodaspect.callsTransferredToAxternal = c.callsTransferredToAxternal;
            aodaspect.callsTransferredToService = c.callsTransferredToService;
            aodaspect.durActiveTime = c.durActiveTime;
            aodaspect.durWrapTime = c.durWrapTime;
            aodaspect.maxCallsInQueue = c.maxCallsInQueue;
            aodaspect.occupancy = c.occupancy;
            aodaspect.serviceType = c.serviceType;
            aodaspect.serviceTypeId = c.serviceTypeId;
            aodaspect.startTimeMilitary = c.startTimeMilitary;
            aodaspect.statusId = c.statusId;
            aodaspect.stopTimeMilitary = c.stopTimeMilitary;
            aodaspect.abandonByDialer24Hour = c.abandonByDialer24Hour;
            aodaspect.abandonedByCustomer = c.abandonedByCustomer;
            aodaspect.abandonedBySwitch = c.abandonedBySwitch;
            aodaspect.agentAnsweringMachines = c.agentAnsweringMachines;
            aodaspect.agentAnsweringMachines24Hour = c.agentAnsweringMachines24Hour;
            aodaspect.abandonedPercent = c.abandonedPercent;
            aodaspect.answeringMachines24Hour = c.answeringMachines24Hour;
            aodaspect.answeringMachinesCurrent = c.answeringMachinesCurrent;
            aodaspect.busyHourCallRate = c.busyHourCallRate;
            aodaspect.callingPartyInfoViolation = c.callingPartyInfoViolation;
            aodaspect.callsAnsweredServiceLevelInterval = c.callsAnsweredServiceLevelInterval;
            aodaspect.callsDialed = c.callsDialed;
            aodaspect.callStartToGreetingAverage = c.callStartToGreetingAverage;
            aodaspect.callStartToGreetingHigh = c.callStartToGreetingHigh;
            aodaspect.callStartToGreetingLow = c.callStartToGreetingLow;
            aodaspect.currentDetectionType = c.currentDetectionType;
            aodaspect.currentDialMode = c.currentDialMode;
            aodaspect.currentDialRatio = c.currentDialRatio;
            aodaspect.currentDialSettingsAutoRevert = c.currentDialSettingsAutoRevert;
            aodaspect.currentQuota = c.currentQuota;
            aodaspect.detectToTransferAverage = c.detectToTransferAverage;
            aodaspect.detectToTransferHigh = c.detectToTransferHigh;
            aodaspect.detectToTransferLow = c.detectToTransferLow;
            aodaspect.falseNegativeCount = c.falseNegativeCount;
            aodaspect.falsePositiveCount = c.falsePositiveCount;
            aodaspect.greetingToConnectAverage = c.greetingToConnectAverage;
            aodaspect.greetingToconnectHigh = c.greetingToconnectHigh;
            aodaspect.greetingToconnectLow = c.greetingToconnectLow;
            aodaspect.greetingTodetectAverage = c.greetingTodetectAverage;
            aodaspect.greetingTodetectHigh = c.greetingTodetectHigh;
            aodaspect.greetingTodetectLow = c.greetingTodetectLow;
            aodaspect.hangup = c.hangup;
            aodaspect.hitRate = c.hitRate;
            aodaspect.lastFailAbandonPercent = c.lastFailAbandonPercent;
            aodaspect.lastTimeToFail = c.lastTimeToFail;
            aodaspect.lastTimeToRecover = c.lastTimeToRecover;
            aodaspect.maxQuota = c.maxQuota;
            aodaspect.minutesLeftOnSchedule = c.minutesLeftOnSchedule;
            aodaspect.numberAlertsOFCOM = c.numberAlertsOFCOM;
            aodaspect.numberAlertsOFCOM24Hours = c.numberAlertsOFCOM24Hours;
            aodaspect.numberHits24Hour = c.numberHits24Hour;
            aodaspect.numberHits24HourForFalsePositive = c.numberHits24HourForFalsePositive;
            aodaspect.numberHitsCurrent = c.numberHitsCurrent;
            aodaspect.numberHitsForFalsePositiveCurrent = c.numberHitsForFalsePositiveCurrent;
            aodaspect.numberMisses24Hour = c.numberMisses24Hour;
            aodaspect.numberMissesCurrent = c.numberMissesCurrent;
            aodaspect.numberOFCOMAbandons24Hour = c.numberOFCOMAbandons24Hour;
            aodaspect.numberOFCOMAbandonsCurrent = c.numberOFCOMAbandonsCurrent;
            aodaspect.numberOfRecoveries = c.numberOfRecoveries;
            aodaspect.numberOfSales = c.numberOfSales;
            aodaspect.peakHourCallRate = c.peakHourCallRate;
            aodaspect.playMessage = c.playMessage;
            aodaspect.playMessageFailure = c.playMessageFailure;
            aodaspect.playMessageTimeSuccess = c.playMessageTimeSuccess;
            aodaspect.playMessageTimeViolation = c.playMessageTimeViolation;
            aodaspect.playScript = c.playScript;
            aodaspect.recoveryTimeBegin = c.recoveryTimeBegin;
            aodaspect.recoveryTimeEnd = c.recoveryTimeEnd;
            aodaspect.ringNoAnswerViolation = c.ringNoAnswerViolation;
            aodaspect.scheduledCallbacks = c.scheduledCallbacks;
            aodaspect.sendDigits = c.sendDigits;
            aodaspect.sendFax = c.sendFax;
            aodaspect.timezoneIdentifier = c.timezoneIdentifier;
            aodaspect.transferTimeSuccess = c.transferTimeSuccess;
            aodaspect.transferTimeViolation = c.transferTimeViolation;
            aodaspect.transferCoConnectAverage = c.transferCoConnectAverage;
            aodaspect.transferToConnectHigh = c.transferToConnectHigh;
            aodaspect.transferToConnectLow = c.transferToConnectLow;
            aodaspect.utcStartTime = c.utcStartTime;
            aodaspect.utcStopTime = c.utcStopTime;
            aodaspect.getAodData = c.getAodData;
            return aodaspect;
        }

        public static acd TransToAcd(object t)
        {
            acd acdaspect = new acd();
            crm_aspect_monitor_acd2 c = (crm_aspect_monitor_acd2)t;
            acdaspect.serviceId = c.serviceId;
            acdaspect.service = c.service;
            acdaspect.status = c.status;
            acdaspect.agentsInAccept = c.agentsInAccept;
            acdaspect.agentsInActive = c.agentsInActive;
            acdaspect.agentsInConnect = c.agentsInConnect;
            acdaspect.agentsInHold = c.agentsInHold;
            acdaspect.agentsInIdle = c.agentsInIdle;
            acdaspect.agentsInInternal = c.agentsInInternal;
            acdaspect.agentsInManual = c.agentsInManual;
            acdaspect.agentsInMultil = c.agentsInMultil;
            acdaspect.agentsInNotReady = c.agentsInNotReady;
            acdaspect.agentsInOther = c.agentsInOther;
            acdaspect.agentsInPark = c.agentsInPark;
            acdaspect.agentsInPreview = c.agentsInPreview;
            acdaspect.agentsInWrap = c.agentsInWrap;
            acdaspect.agentsLoggedIn = c.agentsLoggedIn;
            acdaspect.application = c.application;
            acdaspect.applicationId = c.applicationId;
            acdaspect.avgAgentActiveTime = c.avgAgentActiveTime;
            acdaspect.avgAgentIdleTime = c.avgAgentIdleTime;
            acdaspect.avgAgentWrapTime = c.avgAgentWrapTime;
            acdaspect.avgSpeedOfAnswer = c.avgSpeedOfAnswer;
            acdaspect.avgTimeInQueue = c.avgTimeInQueue;
            acdaspect.avgTimeToAbandon = c.avgTimeToAbandon;
            acdaspect.avgWaitTime = c.avgWaitTime;
            acdaspect.callsAbandonedBeforeQueue = c.callsAbandonedBeforeQueue;
            acdaspect.callsAbandonedBeforeServiceLevelInterval = c.callsAbandonedBeforeServiceLevelInterval;
            acdaspect.callsAbandonedBeforeServiceLevelIntervalDaily = c.callsAbandonedBeforeServiceLevelIntervalDaily;
            acdaspect.callsAbandonedBeforeShortCallInterval = c.callsAbandonedBeforeShortCallInterval;
            acdaspect.callsAbandonedBeforeShortCallIntervalDaily = c.callsAbandonedBeforeShortCallIntervalDaily;
            acdaspect.callsAbandonedInQueue = c.callsAbandonedInQueue;
            acdaspect.callsAbandonedTotal = c.callsAbandonedTotal;
            acdaspect.callsAbandonedTotalDaily = c.callsAbandonedTotalDaily;
            acdaspect.callsAnswered = c.callsAnswered;
            acdaspect.callsInProgress = c.callsInProgress;
            acdaspect.callsInQueue = c.callsInQueue;
            acdaspect.callsInVoiceMail = c.callsInVoiceMail;
            acdaspect.callsOffered = c.callsOffered;
            acdaspect.callsOfferedServiceLevelInterval = c.callsOfferedServiceLevelInterval;
            acdaspect.callsOverflowed = c.callsOverflowed;
            acdaspect.callsRejected = c.callsRejected;
            acdaspect.callsRerouted = c.callsRerouted;
            acdaspect.callsServicedWithinServiceLevel = c.callsServicedWithinServiceLevel;
            acdaspect.callsServicedWithinServiceLevelDaily = c.callsServicedWithinServiceLevelDaily;
            acdaspect.callsTransferredToAgent = c.callsTransferredToAgent;
            acdaspect.callsTransferredToExternal = c.callsTransferredToExternal;
            acdaspect.callsTransferredToService = c.callsTransferredToService;
            acdaspect.currentLongestQueueWaitSeconds = c.currentLongestQueueWaitSeconds;
            acdaspect.durActiveTime = c.durActiveTime;
            acdaspect.durWrapTime = c.durWrapTime;
            acdaspect.maxCallsInQueue = c.maxCallsInQueue;
            acdaspect.maxWaitInQueue = c.maxWaitInQueue;
            acdaspect.occupancy = c.occupancy;
            acdaspect.percentServiceWithinServiceLevel = c.percentServiceWithinServiceLevel;
            acdaspect.serviceLevelCalculationMethod = c.serviceLevelCalculationMethod;
            acdaspect.serviceType = c.serviceType;
            acdaspect.serviceTypeId = c.serviceTypeId;
            acdaspect.startTimeMilitary = c.startTimeMilitary;
            acdaspect.statusId = c.statusId;
            acdaspect.stopTimeMilitary = c.stopTimeMilitary;
            acdaspect.timezoneIdentifier = c.timezoneIdentifier;
            acdaspect.totalQueuedTime = c.totalQueuedTime;
            acdaspect.totalRoutedToUser = c.totalRoutedToUser;
            acdaspect.totalTimeToService = c.totalTimeToService;
            acdaspect.utcStartTime = c.utcStartTime;
            acdaspect.utcStopTime = c.utcStopTime;
            return acdaspect;
        }

        public static agent TransToAgent(object t)
        {

            agent agentaspect = new agent();
            crm_aspect_monitor_agent2 c = (crm_aspect_monitor_agent2)t;

            agentaspect.userId = c.userId;
            agentaspect.serviceId = c.serviceId;
            agentaspect.serviceType = c.serviceType;
            agentaspect.serviceTypeId = c.serviceTypeId;
            agentaspect.statusId = c.statusId;
            agentaspect.acceptCalls = c.acceptCalls;
            agentaspect.acceptSeconds = c.acceptSeconds;
            agentaspect.acdCalls = c.acdCalls;
            agentaspect.activeSeconds = c.activeSeconds;
            agentaspect.agdCalls = c.agdCalls;
            agentaspect.agentIndex = c.agentIndex;
            agentaspect.aodCalls = c.aodCalls;
            agentaspect.audioPath = c.audioPath;
            agentaspect.chatCalls = c.chatCalls;
            agentaspect.conferenceCalls = c.conferenceCalls;
            agentaspect.connectSeconds = c.connectSeconds;
            agentaspect.consultAtionCalls = c.consultAtionCalls;
            agentaspect.ctiCalls = c.ctiCalls;
            agentaspect.currentServiceId = c.currentServiceId;
            agentaspect.didCalls = c.didCalls;
            agentaspect.emailCalls = c.emailCalls;
            agentaspect.firstName = c.firstName;
            agentaspect.heldCalls = c.heldCalls;
            agentaspect.heldSeconds = c.heldSeconds;
            agentaspect.idleSeconds = c.idleSeconds;
            agentaspect.imCalls = c.imCalls;
            agentaspect.internalCalls = c.internalCalls;
            agentaspect.internalSeconds = c.internalSeconds;
            agentaspect.lastDisposition = c.lastDisposition;
            agentaspect.lastDispositionId = c.lastDispositionId;
            agentaspect.lastName = c.lastName;
            agentaspect.loggedInSeconds = c.loggedInSeconds;
            agentaspect.manualCalls = c.manualCalls;
            agentaspect.manualSeconds = c.manualSeconds;
            agentaspect.monitoringCalls = c.monitoringCalls;
            agentaspect.multiSeconds = c.multiSeconds;
            agentaspect.notReadySeconds = c.notReadySeconds;
            agentaspect.numberOfCallbacks = c.numberOfCallbacks;
            agentaspect.numberOfRefusals = c.numberOfRefusals;
            agentaspect.numberOfSuccesses = c.numberOfSuccesses;
            agentaspect.otherSeconds = c.otherSeconds;
            agentaspect.parkSeconds = c.parkSeconds;
            agentaspect.previewSeconds = c.previewSeconds;
            agentaspect.rejectCalls = c.rejectCalls;
            agentaspect.reservedCalls = c.reservedCalls;
            agentaspect.reservedCallsReceived = c.reservedCallsReceived;
            agentaspect.reservedSeconds = c.reservedSeconds;
            agentaspect.reservedSecondsReceived = c.reservedSecondsReceived;
            agentaspect.station = c.station;
            agentaspect.statusReason = c.statusReason;
            agentaspect.statusReasonId = c.statusReasonId;
            agentaspect.statusSeconds = c.statusSeconds;
            agentaspect.statusStartTimeMilitary = c.statusStartTimeMilitary;
            agentaspect.transferredCalls = c.transferredCalls;
            agentaspect.workgroup = c.workgroup;
            agentaspect.workgroupId = c.workgroupId;
            agentaspect.wrapSeconds = c.wrapSeconds;
            agentaspect.contacts = c.contacts;
            agentaspect.inactiveSeconds = c.inactiveSeconds;
            agentaspect.timezoneIdentifier = c.timezoneIdentifier;
            agentaspect.utcStartTime = c.utcStartTime;
            agentaspect.application = c.application;
            agentaspect.applicationId = c.applicationId;
            agentaspect.service = c.service;
            agentaspect.status = c.status;
            agentaspect.timeArrival = c.timeArrival;

            return agentaspect;
        }

        public static wrokgroup TransToWrokgroup(object t)
        {
            wrokgroup wrokgroupaspect = new wrokgroup();
            crm_aspect_monitor_workgroup2 c = (crm_aspect_monitor_workgroup2)t;

            wrokgroupaspect.workgroupId = c.workgroupId;
            wrokgroupaspect.acceptSeconds = c.acceptSeconds;
            wrokgroupaspect.acdCalls = c.acdCalls;
            wrokgroupaspect.activeSeconds = c.activeSeconds;
            wrokgroupaspect.agdCalls = c.agdCalls;
            wrokgroupaspect.aodCalls = c.aodCalls;
            wrokgroupaspect.chatCalls = c.chatCalls;
            wrokgroupaspect.conferenceCalls = c.conferenceCalls;
            wrokgroupaspect.connectSeconds = c.connectSeconds;
            wrokgroupaspect.consultationCalls = c.consultationCalls;
            wrokgroupaspect.ctiCalls = c.ctiCalls;
            wrokgroupaspect.didCalls = c.didCalls;
            wrokgroupaspect.emailCalls = c.emailCalls;
            wrokgroupaspect.heldCalls = c.heldCalls;
            wrokgroupaspect.heldCeconds = c.heldCeconds;
            wrokgroupaspect.idleCeconds = c.idleCeconds;
            wrokgroupaspect.imCalls = c.imCalls;
            wrokgroupaspect.internalCalls = c.internalCalls;
            wrokgroupaspect.internalSeconds = c.internalSeconds;
            wrokgroupaspect.loggedinSeconds = c.loggedinSeconds;
            wrokgroupaspect.manualCalls = c.manualCalls;
            wrokgroupaspect.manualSeconds = c.manualSeconds;
            wrokgroupaspect.multiSeconds = c.multiSeconds;
            wrokgroupaspect.notReadySeconds = c.notReadySeconds;
            wrokgroupaspect.numberOfCallbacks = c.numberOfCallbacks;
            wrokgroupaspect.numberOfRefusals = c.numberOfRefusals;
            wrokgroupaspect.numberOfSuccesses = c.numberOfSuccesses;
            wrokgroupaspect.otherSeconds = c.otherSeconds;
            wrokgroupaspect.parkSeconds = c.parkSeconds;
            wrokgroupaspect.previewSeconds = c.previewSeconds;
            wrokgroupaspect.reservedCalls = c.reservedCalls;
            wrokgroupaspect.reservedCallsReceived = c.reservedCallsReceived;
            wrokgroupaspect.reservedSeconds = c.reservedSeconds;
            wrokgroupaspect.reservedSecondsReceived = c.reservedSecondsReceived;
            wrokgroupaspect.transferredCalls = c.transferredCalls;
            wrokgroupaspect.workgroup = c.workgroup;
            wrokgroupaspect.wrapSeconds = c.wrapSeconds;
            wrokgroupaspect.acceptedCallsCount = c.acceptedCallsCount;
            wrokgroupaspect.rejectedCallsCount = c.rejectedCallsCount; 


            return wrokgroupaspect;
        }

        public static table TransTotable(object t)
        {
            table tableaspect = new table();
            crm_aspect_monitor_table2 c = (crm_aspect_monitor_table2)t;

            tableaspect.tableId = c.tableId;
            tableaspect.filter = c.filter;
            tableaspect.service = c.service;
            tableaspect.status = c.status;
            tableaspect.application = c.application;
            tableaspect.applicationId = c.applicationId;
            tableaspect.serviceId = c.serviceId;
            tableaspect.serviceType = c.serviceType;
            tableaspect.serviceTypeId = c.serviceTypeId;
            tableaspect.startTimeMilitary = c.startTimeMilitary;
            tableaspect.statusId = c.statusId;
            tableaspect.scheduledCallbacks = c.scheduledCallbacks;
            tableaspect.abandoned = c.abandoned;
            tableaspect.badPhoneNumberCount = c.badPhoneNumberCount;
            tableaspect.dialed = c.dialed;
            tableaspect.endTimeMilitary = c.endTimeMilitary;
            tableaspect.excludedCount = c.excludedCount;
            tableaspect.filterId = c.filterId;
            tableaspect.inProgress = c.inProgress;
            tableaspect.leftToBeDialed = c.leftToBeDialed;
            tableaspect.recordsProcessed = c.recordsProcessed;
            tableaspect.rgBusyQueueCount = c.rgBusyQueueCount;
            tableaspect.selected = c.selected;
            tableaspect.serviceTableId = c.serviceTableId;
            tableaspect.tableName = c.tableName;
            tableaspect.timezoneFailureCount = c.timezoneFailureCount;
            tableaspect.touchedcount = c.touchedcount;
            tableaspect.timezoneIdentifier = c.timezoneIdentifier;
            tableaspect.utcStartTime = c.utcStartTime;
            tableaspect.utcStopTime = c.utcStopTime;

            return tableaspect;
        }
        public static resourcegroup TransToResourceGroup(object t)
        {
            resourcegroup resourcegroupaspect = new resourcegroup();
            crm_aspect_monitor_rgstats2 c = (crm_aspect_monitor_rgstats2)t;
            
            resourcegroupaspect.createtime=c.createtime;
            resourcegroupaspect.allChannelsBusy=c.allChannelsBusy;
            resourcegroupaspect.numBusyChannels=c.numBusyChannels;
            resourcegroupaspect.numIdleChannels=c.numIdleChannels;
            resourcegroupaspect.percentOfBusyState=c.percentOfBusyState;
            resourcegroupaspect.percentOfIdleState=c.percentOfIdleState;
            resourcegroupaspect.resourceGroupId=c.resourceGroupId;
            resourcegroupaspect.resourceGroup = c.resourceGroup;

            return resourcegroupaspect;

        }
    }
}
