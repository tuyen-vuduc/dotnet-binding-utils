using CoreBluetooth;
using Foundation;

namespace AmazonFreeRTOS
{
	// @interface AmazonFreeRTOSDevice : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14AmazonFreeRTOS20AmazonFreeRTOSDevice")]
	[DisableDefaultCtor]
	interface AmazonFreeRTOSDevice
	{
	}

	// @interface AmazonFreeRTOSManager : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14AmazonFreeRTOS21AmazonFreeRTOSManager")]
	interface AmazonFreeRTOSManager
	{
	}

	// @interface AmazonFreeRTOS_Swift_286 (AmazonFreeRTOSManager) <CBPeripheralDelegate>
	[Category]
	[BaseType (typeof(AmazonFreeRTOSManager))]
	interface AmazonFreeRTOSManager_AmazonFreeRTOS_Swift_286 : ICBPeripheralDelegate
	{
		// -(void)peripheral:(CBPeripheral * _Nonnull)peripheral didDiscoverServices:(NSError * _Nullable)error;
		[Export ("peripheral:didDiscoverServices:")]
		void Peripheral (CBPeripheral peripheral, [NullAllowed] NSError error);

		// -(void)peripheral:(CBPeripheral * _Nonnull)peripheral didDiscoverCharacteristicsForService:(CBService * _Nonnull)service error:(NSError * _Nullable)error;
		[Export ("peripheral:didDiscoverCharacteristicsForService:error:")]
		void Peripheral (CBPeripheral peripheral, CBService service, [NullAllowed] NSError error);

		// -(void)peripheral:(CBPeripheral * _Nonnull)peripheral didUpdateValueForCharacteristic:(CBCharacteristic * _Nonnull)characteristic error:(NSError * _Nullable)error;
		[Export ("peripheral:didUpdateValueForCharacteristic:error:")]
		void Peripheral (CBPeripheral peripheral, CBCharacteristic characteristic, [NullAllowed] NSError error);

		// -(void)peripheral:(CBPeripheral * _Nonnull)peripheral didWriteValueForCharacteristic:(CBCharacteristic * _Nonnull)characteristic error:(NSError * _Nullable)error;
		[Export ("peripheral:didWriteValueForCharacteristic:error:")]
		void Peripheral (CBPeripheral peripheral, CBCharacteristic characteristic, [NullAllowed] NSError error);
	}

	// @interface AmazonFreeRTOS_Swift_302 (AmazonFreeRTOSManager) <CBCentralManagerDelegate>
	[Category]
	[BaseType (typeof(AmazonFreeRTOSManager))]
	interface AmazonFreeRTOSManager_AmazonFreeRTOS_Swift_302 : ICBCentralManagerDelegate
	{
		// -(void)centralManagerDidUpdateState:(CBCentralManager * _Nonnull)central;
		[Export ("centralManagerDidUpdateState:")]
		void CentralManagerDidUpdateState (CBCentralManager central);

		// -(void)centralManager:(CBCentralManager * _Nonnull)_ didDiscoverPeripheral:(CBPeripheral * _Nonnull)peripheral advertisementData:(NSDictionary<NSString *,id> * _Nonnull)advertisementData RSSI:(NSNumber * _Nonnull)RSSI;
		[Export ("centralManager:didDiscoverPeripheral:advertisementData:RSSI:")]
		void CentralManager (CBCentralManager _, CBPeripheral peripheral, NSDictionary<NSString, NSObject> advertisementData, NSNumber RSSI);

		// -(void)centralManager:(CBCentralManager * _Nonnull)_ didConnectPeripheral:(CBPeripheral * _Nonnull)peripheral;
		[Export ("centralManager:didConnectPeripheral:")]
		void CentralManager (CBCentralManager _, CBPeripheral peripheral);

		// -(void)centralManager:(CBCentralManager * _Nonnull)central didDisconnectPeripheral:(CBPeripheral * _Nonnull)peripheral error:(NSError * _Nullable)error;
		[Export ("centralManager:didDisconnectPeripheral:error:")]
		void CentralManager (CBCentralManager central, CBPeripheral peripheral, [NullAllowed] NSError error);

		// -(void)centralManager:(CBCentralManager * _Nonnull)_ didFailToConnectPeripheral:(CBPeripheral * _Nonnull)peripheral error:(NSError * _Nullable)error;
		[Export ("centralManager:didFailToConnectPeripheral:error:")]
		void CentralManager (CBCentralManager _, CBPeripheral peripheral, [NullAllowed] NSError error);
	}
}
