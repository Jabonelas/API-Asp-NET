using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbEst
{
    public int IdEst { get; set; }

    public DateTime EsDtCri { get; set; }

    public DateTime EsDtAlt { get; set; }

    public DateTime? EsDtAcs { get; set; }

    public string? EsDskCaption { get; set; }

    public decimal? EsDskIndex { get; set; }

    public string? EsDskSerialNumber { get; set; }

    public decimal? EsDskSignature { get; set; }

    public decimal? EsDskSize { get; set; }

    public string? EsDskStatus { get; set; }

    public string? EsNicAdapterType { get; set; }

    public decimal? EsNicAdapterTypeId { get; set; }

    public string? EsNicCaption { get; set; }

    public string? EsNicDescription { get; set; }

    public decimal? EsNicInterfaceIndex { get; set; }

    public string? EsNicMacAddress { get; set; }

    public string? EsNicMacAddressVpn { get; set; }

    public string? EsNicManufacturer { get; set; }

    public string? EsNicName { get; set; }

    public decimal? EsNicNetEnabled { get; set; }

    public decimal? EsNicSpeed { get; set; }

    public decimal? EsNicCfgDhcpenabled { get; set; }

    public string? EsNicCfgDhcpserver { get; set; }

    public string? EsNicCfgDnsdomain { get; set; }

    public string? EsNicCfgIpaddress { get; set; }

    public string? EsNicCfgIpaddressVpn { get; set; }

    public decimal? EsNicCfgIpconnectionMetric { get; set; }

    public decimal? EsNicCfgIpenabled { get; set; }

    public decimal? EsPcPgFlAllocatedBaseSize { get; set; }

    public decimal? EsPcPgFlCurrentUsage { get; set; }

    public decimal? EsPcPgFlPeakUsage { get; set; }

    public string? EsPcPowInstanceId { get; set; }

    public string? EsPcPowElementName { get; set; }

    public string? EsPcLdCaption { get; set; }

    public decimal? EsPcLdCompressed { get; set; }

    public decimal? EsPcLdConfigManagerErrorCode { get; set; }

    public string? EsPcLdDeviceId { get; set; }

    public decimal? EsPcLdDriveType { get; set; }

    public string? EsPcLdFileSystem { get; set; }

    public decimal? EsPcLdFreeSpace { get; set; }

    public decimal? EsPcLdLastErrorCode { get; set; }

    public string? EsPcLdName { get; set; }

    public decimal? EsPcLdSize { get; set; }

    public decimal? EsPcLdVolumeDirty { get; set; }

    public string? EsPcLdVolumeSerialNumber { get; set; }

    public decimal? EsPcAutomaticManagedPagefile { get; set; }

    public decimal? EsPcAutomaticResetBootOption { get; set; }

    public decimal? EsPcAutomaticResetCapability { get; set; }

    public decimal? EsPcBootRomsupported { get; set; }

    public string? EsPcBootupState { get; set; }

    public short EsPcCurrentTimeZone { get; set; }

    public decimal? EsPcDaylightInEffect { get; set; }

    public string? EsPcDnshostName { get; set; }

    public decimal? EsPcDomainRole { get; set; }

    public decimal? EsPcEnableDaylightSavingsTime { get; set; }

    public decimal? EsPcHypervisorPresent { get; set; }

    public string? EsPcManufacturer { get; set; }

    public decimal? EsPcNetworkServerModeEnabled { get; set; }

    public decimal? EsPcNumberOfLogicalProcessors { get; set; }

    public decimal? EsPcNumberOfProcessors { get; set; }

    public decimal? EsPcPcsystemType { get; set; }

    public decimal? EsPcTotalPhysicalMemory { get; set; }

    public string? EsPcUserName { get; set; }

    public decimal? EsPcWakeUpType { get; set; }

    public string? EsBiosCaption { get; set; }

    public string? EsBiosSerialNumber { get; set; }

    public string? EsBiosSmbiosbiosversion { get; set; }

    public string? EsBiosSoftwareElementId { get; set; }

    public string? EsBoardManufacturer { get; set; }

    public string? EsBoardProduct { get; set; }

    public string? EsBoardSerialNumber { get; set; }

    public string? EsBoardStatus { get; set; }

    public string? EsBoardVersion { get; set; }

    public string? EsPcOsBuildNumber { get; set; }

    public string? EsPcOsCaption { get; set; }

    public string? EsPcOsCodeSet { get; set; }

    public string? EsPcOsCountryCode { get; set; }

    public decimal? EsPcOsCurrentTimeZone { get; set; }

    public decimal? EsPcOsFreePhysicalMemory { get; set; }

    public decimal? EsPcOsFreeSpaceInPagingFiles { get; set; }

    public decimal? EsPcOsFreeVirtualMemory { get; set; }

    public DateTime? EsPcOsInstallDate { get; set; }

    public DateTime? EsPcOsLastBootUpTime { get; set; }

    public DateTime? EsPcOsLocalDateTime { get; set; }

    public string? EsPcOsLocale { get; set; }

    public decimal? EsPcOsNumberOfProcesses { get; set; }

    public decimal? EsPcOsNumberOfUsers { get; set; }

    public decimal? EsPcOsOperatingSystemSku { get; set; }

    public string? EsPcOsarchitecture { get; set; }

    public decimal? EsPcOslanguage { get; set; }

    public decimal? EsPcOsproductSuite { get; set; }

    public decimal? EsPcOsPortableOperatingSystem { get; set; }

    public decimal? EsPcOsPrimary { get; set; }

    public decimal? EsPcOsProductType { get; set; }

    public string? EsPcOsRegisteredUser { get; set; }

    public string? EsPcOsSerialNumber { get; set; }

    public decimal? EsPcOsServicePackMajorVersion { get; set; }

    public decimal? EsPcOsServicePackMinorVersion { get; set; }

    public decimal? EsPcOsSizeStoredInPagingFiles { get; set; }

    public decimal? EsPcOsSuiteMask { get; set; }

    public string? EsPcOsSystemDrive { get; set; }

    public decimal? EsPcOsTotalSwapSpaceSize { get; set; }

    public decimal? EsPcOsTotalVirtualMemorySize { get; set; }

    public decimal? EsPcOsTotalVisibleMemorySize { get; set; }

    public string? EsPcOsVersion { get; set; }

    public string? EsProcHandle { get; set; }

    public decimal? EsProcHandleCount { get; set; }

    public decimal? EsProcKernelModeTime { get; set; }

    public decimal? EsProcOtherOperationCount { get; set; }

    public decimal? EsProcOtherTransferCount { get; set; }

    public decimal? EsProcPageFaults { get; set; }

    public decimal? EsProcPageFileUsage { get; set; }

    public decimal? EsProcPeakPageFileUsage { get; set; }

    public decimal? EsProcPeakVirtualSize { get; set; }

    public decimal? EsProcPeakWorkingSetSize { get; set; }

    public decimal? EsProcPriority { get; set; }

    public decimal? EsProcPrivatePageCount { get; set; }

    public decimal? EsProcProcessId { get; set; }

    public decimal? EsProcReadOperationCount { get; set; }

    public decimal? EsProcReadTransferCount { get; set; }

    public decimal? EsProcThreadCount { get; set; }

    public decimal? EsProcUserModeTime { get; set; }

    public decimal? EsProcVirtualSize { get; set; }

    public decimal? EsProcWorkingSetSize { get; set; }

    public decimal? EsProcWriteOperationCount { get; set; }

    public decimal? EsProcWriteTransferCount { get; set; }

    public decimal? EsPcPrcAddressWidth { get; set; }

    public decimal? EsPcPrcArchitecture { get; set; }

    public decimal? EsPcPrcAvailability { get; set; }

    public string? EsPcPrcCaption { get; set; }

    public decimal? EsPcPrcCharacteristics { get; set; }

    public decimal? EsPcPrcConfigManagerErrorCode { get; set; }

    public decimal? EsPcPrcConfigManagerUserConfig { get; set; }

    public decimal? EsPcPrcCpuStatus { get; set; }

    public decimal? EsPcPrcCurrentClockSpeed { get; set; }

    public decimal? EsPcPrcCurrentVoltage { get; set; }

    public decimal? EsPcPrcDataWidth { get; set; }

    public decimal? EsPcPrcExtClock { get; set; }

    public decimal? EsPcPrcFamily { get; set; }

    public decimal? EsPcPrcL2cacheSize { get; set; }

    public decimal? EsPcPrcL2cacheSpeed { get; set; }

    public decimal? EsPcPrcL3cacheSize { get; set; }

    public decimal? EsPcPrcL3cacheSpeed { get; set; }

    public decimal? EsPcPrcLevel { get; set; }

    public decimal? EsPcPrcLoadPercentage { get; set; }

    public decimal? EsPcPrcMaxClockSpeed { get; set; }

    public string? EsPcPrcName { get; set; }

    public decimal? EsPcPrcNumberOfCores { get; set; }

    public decimal? EsPcPrcNumberOfEnabledCore { get; set; }

    public decimal? EsPcPrcNumberOfLogicalProcessors { get; set; }

    public decimal? EsPcPrcPowerManagementSupported { get; set; }

    public string? EsPcPrcProcessorId { get; set; }

    public decimal? EsPcPrcProcessorType { get; set; }

    public decimal? EsPcPrcRevision { get; set; }

    public decimal? EsPcPrcSecondLevelAddressTranslationExtensions { get; set; }

    public string? EsPcPrcStatus { get; set; }

    public decimal? EsPcPrcStatusInfo { get; set; }

    public string? EsPcPrcSystemName { get; set; }

    public decimal? EsPcPrcThreadCount { get; set; }

    public decimal? EsGpuAdapterRam { get; set; }

    public decimal? EsGpuAvailability { get; set; }

    public decimal? EsGpuConfigManagerErrorCode { get; set; }

    public decimal? EsGpuCurrentBitsPerPixel { get; set; }

    public decimal? EsGpuCurrentHorizontalResolution { get; set; }

    public decimal? EsGpuCurrentNumberOfColors { get; set; }

    public decimal? EsGpuCurrentRefreshRate { get; set; }

    public decimal? EsGpuCurrentScanMode { get; set; }

    public decimal? EsGpuCurrentVerticalResolution { get; set; }

    public decimal? EsGpuDitherType { get; set; }

    public string? EsGpuDriverVersion { get; set; }

    public string? EsGpuStatus { get; set; }

    public string? EsGpuVideoProcessor { get; set; }

    public int? FkTbMatriz { get; set; }

    public virtual TbMarcaProduto? FkTbMatrizNavigation { get; set; }

    public virtual ICollection<TbHistorico> TbHistoricos { get; set; } = new List<TbHistorico>();

    public virtual ICollection<TbJornadum> TbJornada { get; set; } = new List<TbJornadum>();

    public virtual ICollection<TbProduto> TbProdutos { get; set; } = new List<TbProduto>();
}
