package shoppinglist.bindingModel;

import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;

public class ProductBindingModel {
    private int priority;

    private String name;

    private int quantity;

    private String status;

    public ProductBindingModel() {
    }

    public int getPriority() {
        return priority;
    }

    public void setPriority(int priority) {
        this.priority = priority;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }
}
