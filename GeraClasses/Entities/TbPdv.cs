using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbPdv
{
    public int IdPdv { get; set; }

    public string? PdvServ { get; set; }

    public string? PdvHost { get; set; }

    public DateTime PdvDtCri { get; set; }

    public DateTime PdvDtAlt { get; set; }

    public DateTime? PdvDtAcs { get; set; }

    public int? PdvDesat { get; set; }

    public short PdvPdvNum { get; set; }

    public short PdvNfeHomSerie { get; set; }

    public int PdvNfeHomNum { get; set; }

    public short PdvNfeProdSerie { get; set; }

    public int PdvNfeProdNum { get; set; }

    public string? PdvDskCaption { get; set; }

    public int? PdvDskIndex { get; set; }

    public string? PdvDskSerialNumber { get; set; }

    public int? PdvDskSignature { get; set; }

    public long? PdvDskSize { get; set; }

    public string? PdvDskStatus { get; set; }

    public string? PdvNicAdapterType { get; set; }

    public int? PdvNicAdapterTypeId { get; set; }

    public string? PdvNicCaption { get; set; }

    public string? PdvNicDescription { get; set; }

    public int? PdvNicInterfaceIndex { get; set; }

    public string? PdvNicMacAddress { get; set; }

    public string? PdvNicMacAddressVpn { get; set; }

    public string? PdvNicManufacturer { get; set; }

    public string? PdvNicName { get; set; }

    public int? PdvNicNetEnabled { get; set; }

    public long? PdvNicSpeed { get; set; }

    public int? PdvNicCfgDhcpenabled { get; set; }

    public string? PdvNicCfgDhcpserver { get; set; }

    public string? PdvNicCfgDnsdomain { get; set; }

    public string? PdvNicCfgIpaddress { get; set; }

    public string? PdvNicCfgIpaddressVpn { get; set; }

    public int? PdvNicCfgIpconnectionMetric { get; set; }

    public int? PdvNicCfgIpenabled { get; set; }

    public int? PdvPcPgFlAllocatedBaseSize { get; set; }

    public int? PdvPcPgFlCurrentUsage { get; set; }

    public int? PdvPcPgFlPeakUsage { get; set; }

    public string? PdvPcPowInstanceId { get; set; }

    public string? PdvPcPowElementName { get; set; }

    public string? PdvPcLdCaption { get; set; }

    public int? PdvPcLdCompressed { get; set; }

    public int? PdvPcLdConfigManagerErrorCode { get; set; }

    public string? PdvPcLdDeviceId { get; set; }

    public int? PdvPcLdDriveType { get; set; }

    public string? PdvPcLdFileSystem { get; set; }

    public int? PdvPcLdFreeSpace { get; set; }

    public int? PdvPcLdLastErrorCode { get; set; }

    public string? PdvPcLdName { get; set; }

    public int? PdvPcLdSize { get; set; }

    public int? PdvPcLdVolumeDirty { get; set; }

    public string? PdvPcLdVolumeSerialNumber { get; set; }

    public int? PdvPcAutomaticManagedPagefile { get; set; }

    public int? PdvPcAutomaticResetBootOption { get; set; }

    public int? PdvPcAutomaticResetCapability { get; set; }

    public int? PdvPcBootRomsupported { get; set; }

    public string? PdvPcBootupState { get; set; }

    public short PdvPcCurrentTimeZone { get; set; }

    public int? PdvPcDaylightInEffect { get; set; }

    public string? PdvPcDnshostName { get; set; }

    public int? PdvPcDomainRole { get; set; }

    public int? PdvPcEnableDaylightSavingsTime { get; set; }

    public int? PdvPcHypervisorPresent { get; set; }

    public string? PdvPcManufacturer { get; set; }

    public int? PdvPcNetworkServerModeEnabled { get; set; }

    public int? PdvPcNumberOfLogicalProcessors { get; set; }

    public int? PdvPcNumberOfProcessors { get; set; }

    public int? PdvPcPcsystemType { get; set; }

    public int? PdvPcTotalPhysicalMemory { get; set; }

    public string? PdvPcUserName { get; set; }

    public int? PdvPcWakeUpType { get; set; }

    public string? PdvBiosCaption { get; set; }

    public string? PdvBiosSerialNumber { get; set; }

    public string? PdvBiosSmbiosbiosversion { get; set; }

    public string? PdvBiosSoftwareElementId { get; set; }

    public string? PdvBoardManufacturer { get; set; }

    public string? PdvBoardProduct { get; set; }

    public string? PdvBoardSerialNumber { get; set; }

    public string? PdvBoardStatus { get; set; }

    public string? PdvBoardVersion { get; set; }

    public string? PdvPcOsBuildNumber { get; set; }

    public string? PdvPcOsCaption { get; set; }

    public string? PdvPcOsCodeSet { get; set; }

    public string? PdvPcOsCountryCode { get; set; }

    public int? PdvPcOsCurrentTimeZone { get; set; }

    public int? PdvPcOsFreePhysicalMemory { get; set; }

    public int? PdvPcOsFreeSpaceInPagingFiles { get; set; }

    public int? PdvPcOsFreeVirtualMemory { get; set; }

    public DateTime? PdvPcOsInstallDate { get; set; }

    public DateTime? PdvPcOsLastBootUpTime { get; set; }

    public DateTime? PdvPcOsLocalDateTime { get; set; }

    public string? PdvPcOsLocale { get; set; }

    public int? PdvPcOsNumberOfProcesses { get; set; }

    public int? PdvPcOsNumberOfUsers { get; set; }

    public int? PdvPcOsOperatingSystemSku { get; set; }

    public string? PdvPcOsarchitecture { get; set; }

    public int? PdvPcOslanguage { get; set; }

    public int? PdvPcOsproductSuite { get; set; }

    public int? PdvPcOsPortableOperatingSystem { get; set; }

    public int? PdvPcOsPrimary { get; set; }

    public int? PdvPcOsProductType { get; set; }

    public string? PdvPcOsRegisteredUser { get; set; }

    public string? PdvPcOsSerialNumber { get; set; }

    public int? PdvPcOsServicePackMajorVersion { get; set; }

    public int? PdvPcOsServicePackMinorVersion { get; set; }

    public int? PdvPcOsSizeStoredInPagingFiles { get; set; }

    public int? PdvPcOsSuiteMask { get; set; }

    public string? PdvPcOsSystemDrive { get; set; }

    public int? PdvPcOsTotalSwapSpaceSize { get; set; }

    public int? PdvPcOsTotalVirtualMemorySize { get; set; }

    public int? PdvPcOsTotalVisibleMemorySize { get; set; }

    public string? PdvPcOsVersion { get; set; }

    public string? PdvProcHandle { get; set; }

    public int? PdvProcHandleCount { get; set; }

    public int? PdvProcKernelModeTime { get; set; }

    public int? PdvProcOtherOperationCount { get; set; }

    public int? PdvProcOtherTransferCount { get; set; }

    public int? PdvProcPageFaults { get; set; }

    public int? PdvProcPageFileUsage { get; set; }

    public int? PdvProcPeakPageFileUsage { get; set; }

    public int? PdvProcPeakVirtualSize { get; set; }

    public int? PdvProcPeakWorkingSetSize { get; set; }

    public int? PdvProcPriority { get; set; }

    public int? PdvProcPrivatePageCount { get; set; }

    public int? PdvProcProcessId { get; set; }

    public int? PdvProcReadOperationCount { get; set; }

    public int? PdvProcReadTransferCount { get; set; }

    public int? PdvProcThreadCount { get; set; }

    public int? PdvProcUserModeTime { get; set; }

    public int? PdvProcVirtualSize { get; set; }

    public int? PdvProcWorkingSetSize { get; set; }

    public int? PdvProcWriteOperationCount { get; set; }

    public int? PdvProcWriteTransferCount { get; set; }

    public int? PdvPcPrcAddressWidth { get; set; }

    public int? PdvPcPrcArchitecture { get; set; }

    public int? PdvPcPrcAvailability { get; set; }

    public string? PdvPcPrcCaption { get; set; }

    public int? PdvPcPrcCharacteristics { get; set; }

    public int? PdvPcPrcConfigManagerErrorCode { get; set; }

    public int? PdvPcPrcConfigManagerUserConfig { get; set; }

    public int? PdvPcPrcCpuStatus { get; set; }

    public int? PdvPcPrcCurrentClockSpeed { get; set; }

    public int? PdvPcPrcCurrentVoltage { get; set; }

    public int? PdvPcPrcDataWidth { get; set; }

    public int? PdvPcPrcExtClock { get; set; }

    public int? PdvPcPrcFamily { get; set; }

    public int? PdvPcPrcL2cacheSize { get; set; }

    public int? PdvPcPrcL2cacheSpeed { get; set; }

    public int? PdvPcPrcL3cacheSize { get; set; }

    public int? PdvPcPrcL3cacheSpeed { get; set; }

    public int? PdvPcPrcLevel { get; set; }

    public int? PdvPcPrcLoadPercentage { get; set; }

    public int? PdvPcPrcMaxClockSpeed { get; set; }

    public string? PdvPcPrcName { get; set; }

    public int? PdvPcPrcNumberOfCores { get; set; }

    public int? PdvPcPrcNumberOfEnabledCore { get; set; }

    public int? PdvPcPrcNumberOfLogicalProcessors { get; set; }

    public int? PdvPcPrcPowerManagementSupported { get; set; }

    public string? PdvPcPrcProcessorId { get; set; }

    public int? PdvPcPrcProcessorType { get; set; }

    public int? PdvPcPrcRevision { get; set; }

    public int? PdvPcPrcSecondLevelAddressTranslationExtensions { get; set; }

    public string? PdvPcPrcStatus { get; set; }

    public int? PdvPcPrcStatusInfo { get; set; }

    public string? PdvPcPrcSystemName { get; set; }

    public int? PdvPcPrcThreadCount { get; set; }

    public int? PdvGpuAdapterRam { get; set; }

    public int? PdvGpuAvailability { get; set; }

    public int? PdvGpuConfigManagerErrorCode { get; set; }

    public int? PdvGpuCurrentBitsPerPixel { get; set; }

    public int? PdvGpuCurrentHorizontalResolution { get; set; }

    public int? PdvGpuCurrentNumberOfColors { get; set; }

    public int? PdvGpuCurrentRefreshRate { get; set; }

    public int? PdvGpuCurrentScanMode { get; set; }

    public int? PdvGpuCurrentVerticalResolution { get; set; }

    public int? PdvGpuDitherType { get; set; }

    public string? PdvGpuDriverVersion { get; set; }

    public string? PdvGpuStatus { get; set; }

    public string? PdvGpuVideoProcessor { get; set; }

    public byte PdvPersTim { get; set; }

    public DateTime? PdvPdvUpdRunVerDt { get; set; }

    public string? PdvPdvUpdRunVer { get; set; }

    public DateTime? PdvPdvUpdNewVerDt { get; set; }

    public string? PdvPdvUpdNewVer { get; set; }

    public int? PdvPdvUpdReady { get; set; }

    public int? FkTbAtor { get; set; }

    public virtual TbAtor? FkTbAtorNavigation { get; set; }

    public virtual ICollection<TbClasCont2> TbClasCont2s { get; set; } = new List<TbClasCont2>();

    public virtual ICollection<TbJornadum> TbJornada { get; set; } = new List<TbJornadum>();

    public virtual ICollection<TbNfeEnviadaFilial> TbNfeEnviadaFilials { get; set; } = new List<TbNfeEnviadaFilial>();
}
