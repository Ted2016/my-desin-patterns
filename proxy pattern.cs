interface Iperforms {
	perform1() {

	}

	perform2() {

	}
}


class proxy : Iperforms {

	public entity en;
	proxy(entity some) {
		en = new entity();
		en = some;
	}

	public void perform1() {
		en.perform1();
	}

	public void perform2() {
		en.perform2;
	}

}

class entity : Iperforms {

	public void perform1() {

	}

	public void perform2() {

	}

}