public class Main {
    public static void main(String[] args) {
        Vehicle car = new Car("Tesla", "Model S", 2020, 4, true);
        Vehicle truck = new Truck("Ford", "F-150", 2018, 1200, true);

        car.displayInfo();
        truck.displayInfo();
    }
}

class Car extends Vehicle {
    private int numOfDoors;
    private boolean isElectric;

    public Car(String brand, String model, int year, int numOfDoors, boolean isElectric) {
        super(brand, model, year);
        this.numOfDoors = numOfDoors;
        this.isElectric = isElectric;
    }

    @Override
    public void displayInfo() {
        super.displayInfo();
        System.out.println("Car Details: " + numOfDoors + "-door, " + (isElectric ? "Electric" : "Non-electric"));
    }
}

class Truck extends Vehicle {
    private double payloadCapacity;
    private boolean fourWheelDrive;

    public Truck(String brand, String model, int year, double payloadCapacity, boolean fourWheelDrive) {
        super(brand, model, year);
        this.payloadCapacity = payloadCapacity;
        this.fourWheelDrive = fourWheelDrive;
    }

    @Override
    public void displayInfo() {
        super.displayInfo();
        System.out.println("Truck Details: " + payloadCapacity + "kg capacity, " +
                (fourWheelDrive ? "4WD" : "2WD"));
    }
}

class Vehicle {
    private String brand;
    private String model;
    private int year;

    public Vehicle(String brand, String model, int year) {
        this.brand = brand;
        this.model = model;
        this.year = year;
    }

    public void displayInfo() {
        System.out.println("Vehicle: " + brand + " " + model + " (" + year + ")");
    }
}